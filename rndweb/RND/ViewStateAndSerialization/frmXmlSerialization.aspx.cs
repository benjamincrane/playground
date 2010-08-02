using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Text;

namespace RND.ViewStateAndSerialization
{
	/// <summary>
	/// Summary description for frmXmlSerialization_.
	/// </summary>
	public class frmXmlSerialization : System.Web.UI.Page
	{
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion
	}
    [Serializable()]
    class MyClass_ : ISerializable
    {
        public int a;
        public float b;
        public string c;
        public string abc;
        public MyClass_(int a,float b,string c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            abc = a + b + c;
        }        
        public MyClass_(SerializationInfo info, StreamingContext context)
        {
            a  = info.GetInt32("a");
            b  = info.GetSingle("b");
            c  = info.GetString("c");
            abc = a + b + c;
        }

        #region ISerializable Members
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("a",a);
            info.AddValue("b",b);
            info.AddValue("c",c);
        }

        #endregion
        
    }
}
