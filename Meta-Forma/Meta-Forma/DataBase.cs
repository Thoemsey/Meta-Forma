﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Meta_Forma
{
    public class DataBase
    {

        //Datenbankanbindung
        private SpielController controller;
        public SpielController Controller
        {
            get { return controller; }
            set { controller = value; }
        }
        public String getLoesungById(int id)
        {
            //Bei angabe des lvls erhält man die Lösung als String zurück
            using (Entities context = new Entities())
            {
                loesung sol = context.loesung.FirstOrDefault(loes => loes.loesung_id == id);
                if (sol != null)
                {
                    return sol.loesung_code;
                }
                else
                {
                    return null;
                }
            }
        }

        public String getRulesById(int id)
        {
            //bei angabe des Levels erhält man den Pfad zum Bild der regeln zurück
            using (Entities context = new Entities())
            {
                level lvl = context.level.FirstOrDefault(rule => rule.level_id == id);
                if (lvl != null)
                {
                    return lvl.regeln;
                }
                else
                {
                    return null;
                }
            }
        }

        public List<int> getLvlByDifficulty(int diff)
        {
            //bei angabe der Schwierigkeit erhält man die dazugehörigen Lvl zurück
            using (Entities context = new Entities())
            {

                List<int> lvl = context.level.Where(l => l.schwierigkeit == diff).Select(l => l.level_id).ToList();

                if (lvl != null)
                {
                    return lvl;
                }
                else
                {
                    lvl.Add(0);
                    lvl.Add(0);
                    return lvl;
                }

            }
        }

    }
}
