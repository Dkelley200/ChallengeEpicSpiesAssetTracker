using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] assetsArray = new string[0];
                int[] electionsArray = new int[0];
                double[] subterfugeArray = new double[0];
                ViewState.Add("Assets", assetsArray);
                ViewState.Add("Elections", electionsArray);
                ViewState.Add("Subterfuge", subterfugeArray);

            }
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            string[] assets = (String[])ViewState["Assets"];
            int[] elections = (int[])ViewState["Elections"];
            double[] subterfuge = (double[])ViewState["Subterfuge"];

            int arrayLength = assets.Length + 1;

            Array.Resize(ref assets, arrayLength);
            Array.Resize(ref elections, arrayLength);
            Array.Resize(ref subterfuge, arrayLength);

            int newIndex = assets.GetUpperBound(0);

            assets[newIndex] = assetNameTextBox.Text;
            elections[newIndex] = int.Parse(electionsRiggedTextBox.Text);
            subterfuge[newIndex] = double.Parse(actsOfSubterfugeTextBox.Text);

            ViewState["Assets"] = assets;
            ViewState["Elections"] = elections;
            ViewState["Subterfuge"] = subterfuge;

            resultLabel.Text = string.Format("Total Elections Rigged: {0} <br/>" +
            "Average Acts of Subterfuge per Asset: {1:N2}<br/>" +
           "(Last Asset you Added : {2})",
               elections.Sum(),
               subterfuge.Average(),
               assets[newIndex]);

            assetNameTextBox.Text = "";
            electionsRiggedTextBox.Text = "";
            actsOfSubterfugeTextBox.Text = "";
        }
    }
}