using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;

namespace WhatQuestNext
{
    public partial class main : System.Web.UI.Page
    {
        // Maybe use this...
        //Skill Total = new Skill(0, 0, 0, 0);
        //Skill Attack = new Skill(1, 0, 0, 0);
        //Skill Defence= new Skill(2, 0, 0, 0);
        //Skill Strength = new Skill(3, 0, 0, 0);
        //Skill Hitpoints = new Skill(4, 0, 0, 0);
        //Skill Ranged = new Skill(5, 0, 0, 0);
        //Skill Prayer = new Skill(6, 0, 0, 0);
        //Skill Magic = new Skill(7, 0, 0, 0);
        //Skill Cooking = new Skill(8, 0, 0, 0);
        //Skill Woodcutting = new Skill(9, 0, 0, 0);
        //Skill Fletching = new Skill(10, 0, 0, 0);
        //Skill Fishing = new Skill(11, 0, 0, 0);
        //Skill Firemaking = new Skill(12, 0, 0, 0);
        //Skill Crafting = new Skill(13, 0, 0, 0);
        //Skill Smithing = new Skill(14, 0, 0, 0);
        //Skill Mining = new Skill(15, 0, 0, 0);
        //Skill Herblore = new Skill(16, 0, 0, 0);
        //Skill Agility = new Skill(17, 0, 0, 0);
        //Skill Thieving = new Skill(18, 0, 0, 0);
        //Skill Slayer = new Skill(19, 0, 0, 0);
        //Skill Farming = new Skill(20, 0, 0, 0);
        //Skill Runecraft = new Skill(21, 0, 0, 0);
        //Skill Hunter = new Skill(22, 0, 0, 0);
        //Skill Construction = new Skill(23, 0, 0, 0);

        class Quest
        {
            public int id { get; }
            public bool complete { get; set; }
            public string name { get; }
            public List<int> requiredQuests { get; }
            public List<int[]> expRewards { get; } // Skill ID, XP Amount
        }

        class Skill
        {
            public int id { get; }
            public int rank { get; set; }
            public int level { get; set; }
            public int exp { get; set; }

            public Skill(int a, int b, int c, int d)
            {
                this.id = a;
                this.rank = b;
                this.level = c;
                this.exp = d;
            }
        }

        
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        protected void LoadCharacter(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string url = @"https://secure.runescape.com/m=hiscore_oldschool/index_lite.ws?player=" + username;
            string request = GetRequest(url);
            
            List<string> userStats = request.Split(null).ToList<string>();

            for (int i = 0; i < userStats.Count; i++)
            {
                //Remove minigame stats, etc..
                if (userStats[i].StartsWith("-1"))
                {
                    userStats.RemoveAt(i);
                }
            }


            TableRow workRow = new TableRow();

            int numRows = userStats.Count;

            //AddRow("Stat", "Rank", "Level", "Exp");

            List<string> stat = new List<string> { };
            List<string> statNames = new List<string> {
                "Total",
                "Attack",
                "Defence",
                "Strength",
                "Hitpoints",
                "Ranged",
                "Prayer",
                "Magic",
                "Cooking",
                "Woodcutting",
                "Fletching",
                "Fishing",
                "Firemaking",
                "Crafting",
                "Smithing",
                "Mining",
                "Herblore",
                "Agility",
                "Thieving",
                "Farming",
                "Hunter"
            };

            //for (int i = 0; i < 24; i++)
            //foreach(string s in userStats) 

            
            for (int i = 0; i < 24; i++)
            {
                stat = userStats[i].Split(',').ToList<string>();
                if (stat[0] != "-1")
                {
                    try
                    {
                        //Ex: AddRow("Attack", rank, level, exp);
                        AddRow(statNames[i], stat[0], stat[1], stat[2]);
                    }
                    catch { }
                }
            }
            
        }

        private void AddRow(string stat, string rank, string level, string exp)
        {
            TableRow r = new TableRow();

            TableCell statCell = new TableCell();
            statCell.Controls.Add(new LiteralControl(stat));

            TableCell rankCell = new TableCell();
            rankCell.Controls.Add(new LiteralControl(rank));

            TableCell levelCell = new TableCell();
            levelCell.Controls.Add(new LiteralControl(level));

            TableCell expCell = new TableCell();
            expCell.Controls.Add(new LiteralControl(exp));

            r.Cells.Add(statCell);
            r.Cells.Add(rankCell);
            r.Cells.Add(levelCell);
            r.Cells.Add(expCell);

            tblCharacterStats.Rows.Add(r);
        }

        protected string GetRequest(string url)
        {
            string html = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }

            return html;
        }
    }
}