using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meta_Forma
{
    public class SpielController
    {
        private Spiel view;

        public SpielController(Spiel view)
        {
            view.Controller = this;
            this.view = view;
        }
        public Spiel View
        {
            get { return view; }
            set { view = value; }
        }

        public void Start()
        {
            view.Visible = true;
        }
        
    }
}
