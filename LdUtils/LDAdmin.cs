using LaunchDarkly.Sdk;
using LaunchDarkly.Sdk.Server;
using System.Text;

namespace LdUtils
{
    public partial class LDAdmin : Form
    {
        private Dictionary<string, string> _envKeys = new Dictionary<string, string> {
            { "Dev", "ld-sdk-key-goes-here"},
            { "Staging", "ld-sdk-key-goes-here"}
        };

        private CheckBox[] _environments;    

        public LDAdmin()
        {
            InitializeComponent();
            _environments = new CheckBox[] { chkDev, chkStaging };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            var result = new StringBuilder();
            var ldFlagName = txtFlagName.Text.Trim();
            var userId = textBox1.Text;
            var user = User.Builder(userId).Build();
            foreach (var env in _environments) {
                if (!env.Checked) {
                    continue;
                }
                
                try
                {
                    var sdkKey = _envKeys[env.Text.Trim()];
                    using (var client = new LdClient(sdkKey))
                    {
                        var details = client.BoolVariationDetail(ldFlagName, user, false);
                        result.AppendLine($"Flag {ldFlagName} for user {userId} enabled? {details.Value.ToString().ToUpper()}. Reason: {details.Reason}");
                        result.AppendLine("");
                    }
                }
                catch (Exception exc)
                {
                    result.Append($"Error querying LD in {env.Text.Trim()}: {exc.Message}.");
                }
            }
            var output = result.ToString();
            txtOutput.Text = string.IsNullOrWhiteSpace(output) ? "No environment selected" : output;
        }
    }
}
