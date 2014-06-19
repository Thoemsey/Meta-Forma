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
        private DataBase db;

        public SpielController(Spiel view, DataBase db)
        {
            view.Controller = this;
            db.Controller = this;
            this.view = view;
            this.db = db;
        }
        public Spiel View
        {
            get { return view; }
            set { view = value; }
        }

        public DataBase DB
        {
            get { return db; }
            set { db = value; }
        }

        public void Start()
        {
            view.Visible = true;
        }
        
    }
}
