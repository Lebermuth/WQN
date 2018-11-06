using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Data;

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

        static DataTable quests = MakeQuestTable();

        static DataTable MakeQuestTable()
        {
            DataTable table = new DataTable();

            //Items...future update. Also list item requirements for each quest.
            //List<string> items = new List<string> { };

            table.Columns.Add("P2P", typeof(bool));
            table.Columns.Add("Completed", typeof(bool));
            table.Columns.Add("Name", typeof(string));
            //table.Columns.Add("Items", typeof(List<string>)); //Comma separated items, split into list if used later
            table.Columns.Add("Attack", typeof(int));
            table.Columns.Add("Defence", typeof(int));
            table.Columns.Add("Strength", typeof(int));
            table.Columns.Add("Hitpoints", typeof(int));
            table.Columns.Add("Ranged", typeof(int));
            table.Columns.Add("Prayer", typeof(int));
            table.Columns.Add("Magic", typeof(int));
            table.Columns.Add("Cooking", typeof(int));
            table.Columns.Add("Woodcutting", typeof(int));
            table.Columns.Add("Fletching", typeof(int));
            table.Columns.Add("Fishing", typeof(int));
            table.Columns.Add("Firemaking", typeof(int));
            table.Columns.Add("Crafting", typeof(int));
            table.Columns.Add("Smithing", typeof(int));
            table.Columns.Add("Mining", typeof(int));
            table.Columns.Add("Herblore", typeof(int));
            table.Columns.Add("Agility", typeof(int));
            table.Columns.Add("Thieving", typeof(int));
            table.Columns.Add("Slayer", typeof(int));
            table.Columns.Add("Farming", typeof(int));
            table.Columns.Add("Runecraft", typeof(int));
            table.Columns.Add("Hunter", typeof(int));
            table.Columns.Add("Construction", typeof(int));

            // Template....
            // quests.Rows[0][i].ToString();
            // where i ==      0      1         2        3     4   5   6      7       8     9       10    11    12     13   14     15        16        17    18   19     20     21      22     23    24        25
            // table.Rows.Add(p2p, completed, questname, atk, def, str, hp, ranged, prayer, mage, cooking, wc, fletch, fish, fm, crafting, smithing, mining, herb, agi, thief, slayer, farming, rc, hunter, construction)

            //------------------------F2P QUESTS--------------------------
            // http://oldschoolrunescape.wikia.com/wiki/Quests/Free-to-play

            table.Rows.Add(0, 0, "Cook's Assistant", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            table.Rows.Add(0, 0, "The Corsair Curse", atk, def, str, hp, ranged, prayer, mage, cooking, wc, 0, fish, fm, crafting, smithing, mining, 0, 0, 0, 0, 0, rc, 0, 0);
            table.Rows.Add(0, 0, "Demon Slayer", atk, def, str, hp, ranged, prayer, mage, cooking, wc, 0, fish, fm, crafting, smithing, mining, 0, 0, 0, 0, 0, rc, 0, 0);
            table.Rows.Add(0, 0, "Ernest the Chicken", atk, def, str, hp, ranged, prayer, mage, cooking, wc, 0, fish, fm, crafting, smithing, mining, 0, 0, 0, 0, 0, rc, 0, 0);
            table.Rows.Add(0, 0, "Fletching", atk, def, str, hp, ranged, prayer, mage, cooking, wc, 0, fish, fm, crafting, smithing, mining, 0, 0, 0, 0, 0, rc, 0, 0);
            table.Rows.Add(0, 0, "Imp Catcher", atk, def, str, hp, ranged, prayer, mage, cooking, wc, 0, fish, fm, crafting, smithing, mining, 0, 0, 0, 0, 0, rc, 0, 0);
            table.Rows.Add(0, 0, "The Knight's Sword", atk, def, str, hp, ranged, prayer, mage, cooking, wc, 0, fish, fm, crafting, smithing, mining, 0, 0, 0, 0, 0, rc, 0, 0);
            table.Rows.Add(0, 0, "Misthalin Mystery", atk, def, str, hp, ranged, prayer, mage, cooking, wc, 0, fish, fm, crafting, smithing, mining, 0, 0, 0, 0, 0, rc, 0, 0);
            table.Rows.Add(0, 0, "Pirate's Treasure", atk, def, str, hp, ranged, prayer, mage, cooking, wc, 0, fish, fm, crafting, smithing, mining, 0, 0, 0, 0, 0, rc, 0, 0);
            table.Rows.Add(0, 0, "Prince Ali Rescue", atk, def, str, hp, ranged, prayer, mage, cooking, wc, 0, fish, fm, crafting, smithing, mining, 0, 0, 0, 0, 0, rc, 0, 0);
            table.Rows.Add(0, 0, "The Restless Ghost", atk, def, str, hp, ranged, prayer, mage, cooking, wc, 0, fish, fm, crafting, smithing, mining, 0, 0, 0, 0, 0, rc, 0, 0);
            table.Rows.Add(0, 0, "Romeo & Juliet", atk, def, str, hp, ranged, prayer, mage, cooking, wc, 0, fish, fm, crafting, smithing, mining, 0, 0, 0, 0, 0, rc, 0, 0);
            table.Rows.Add(0, 0, "Rune Mysteries", atk, def, str, hp, ranged, prayer, mage, cooking, wc, 0, fish, fm, crafting, smithing, mining, 0, 0, 0, 0, 0, rc, 0, 0);
            table.Rows.Add(0, 0, "Sheep Shearer", atk, def, str, hp, ranged, prayer, mage, cooking, wc, 0, fish, fm, crafting, smithing, mining, 0, 0, 0, 0, 0, rc, 0, 0);
            table.Rows.Add(0, 0, "Shield of Arrav", atk, def, str, hp, ranged, prayer, mage, cooking, wc, 0, fish, fm, crafting, smithing, mining, 0, 0, 0, 0, 0, rc, 0, 0);
            table.Rows.Add(0, 0, "Witch's Potion", atk, def, str, hp, ranged, prayer, mage, cooking, wc, 0, fish, fm, crafting, smithing, mining, 0, 0, 0, 0, 0, rc, 0, 0);

            //Big Chompy Bird Hunting
            //table.Rows.Add(1, 0, "Big Chompy Bird Hunting", 0, 0, 0, 0, 30, 0, 0, 30, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            //items.Clear();



            return table;
        }


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
            MakeQuestTable();

            lblTest.Text = quests.Rows[0][1].ToString();

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