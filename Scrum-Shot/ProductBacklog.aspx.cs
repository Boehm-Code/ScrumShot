using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Scrum_Shot
{
    public partial class ProductBacklog1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int numrows = 10;
            int numcells = 5;
            for (int j = 0; j < numrows; j++)
            {
                TableRow r = new TableRow();
                if (j==0)
                {
                    for (int i = 0; i < numcells; i++)
                    {
                        TableCell c = new TableCell();
                        switch (i)
                        {//Einfügen der Story Unterpunkte
                            case 0:
                                
                                break;
                        }
                        c.Controls.Add(new LiteralControl("");
                        r.Cells.Add(c);
                    }
                }
                else
                {

                    for (int i = 0; i < numcells; i++)
                    {
                        TableCell c = new TableCell();
                        c.Controls.Add(new LiteralControl("row "+ j.ToString() + ", cell " + i.ToString()));
                        r.Cells.Add(c);   
                    }
                    
                }
                Table1.Rows.Add(r);
            }
        }

    }
}