using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.ComponentModel;

namespace Programa_6._9
{
    class NCContro : Button
    {
        private bool gigante = true;

        [Description("Dice si el boton se pone gigante")]
        [Category("CosasGigantes")]
        [DefaultValue(true)]

        public bool Gigante
        {
            get { return gigante; }
            set { gigante = value; }
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            if (gigante)
                this.Size = new System.Drawing.Size(150, 150);
            base.OnMouseEnter(e);
        }
    }
}
