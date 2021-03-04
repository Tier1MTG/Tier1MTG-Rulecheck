using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Rulecheck
{
    class SQLQuery
    {
            
        public SQLQuery()
        {

        }

        string host = "localhost";
        string user = "root";
        string port = "3306";
        string pass = "hI5sBtPhjga8Iz9H";

        /*
        * Function that returns an array for the output from SQL-database.
        */
        public Expansion[] getLookupTable(string database)
        {

            string sqlparams = "";
            sqlparams += "server=" + host + ";";
            sqlparams += "user=" + user + ";";
            sqlparams += "database=" + database + ";";
            sqlparams += "port=" + port + ";";
            sqlparams += "password=" + pass + ";";

            MySqlConnection con = new MySqlConnection(sqlparams);

            try
            {

                con.Open();
                MySqlCommand cmd;
                MySqlDataReader rdr;

                string sql;

                sql = "SELECT * FROM aa_expansion_lookup";
                cmd = new MySqlCommand(sql, con);
                rdr = cmd.ExecuteReader();

                Expansion[] expansions;
                List<Expansion> expansionsList = new List<Expansion>();

                while (rdr.Read())
                {
                    //Expansion expansion = ;
                    expansionsList.Add(new Expansion(Convert.ToString(rdr[0]), Convert.ToInt32(rdr[1]), Convert.ToString(rdr[2]), Convert.ToString(rdr[3]), Convert.ToString(rdr[4]) ) );
                }

                expansions = expansionsList.ToArray();

                rdr.Close();
                con.Close();

                return expansions;

            } catch(Exception ex)
            {
                con.Close();
                Console.WriteLine(ex);
                return null;
            }

        }

        /*
        * Function that returns an array of blocknames & blockabbrs
        */
        public string[] getUniqueBlocks(string database)
        {

            string sqlparams = "";
            sqlparams += "server=" + host + ";";
            sqlparams += "user=" + user + ";";
            sqlparams += "database=" + database + ";";
            sqlparams += "port=" + port + ";";
            sqlparams += "password=" + pass + ";";

            MySqlConnection con = new MySqlConnection(sqlparams);

            try
            {

                con.Open();
                MySqlCommand cmd;
                MySqlDataReader rdr;

                string sql;

                sql = "SELECT * FROM aa_expansion_lookup";
                cmd = new MySqlCommand(sql, con);
                rdr = cmd.ExecuteReader();

                string[] blocks;
                List<string> blocksList = new List<string>();

                while (rdr.Read())
                {
                    if(blocksList.IndexOf(Convert.ToString(rdr[3]) + "|" + Convert.ToString(rdr[4])) ==-1)
                    {
                        blocksList.Add(Convert.ToString(rdr[3]) + "|" + Convert.ToString(rdr[4]));
                    }
                }

                blocks = blocksList.ToArray();
                var sortedBlocks = blocks.OrderBy(n => n);

                rdr.Close();
                con.Close();

                return sortedBlocks.ToArray();

            }
            catch (Exception ex)
            {
                con.Close();
                Console.WriteLine(ex);
                return null;
            }

        }
        
        /*
        * Function that returns the given singles from a table and from a database, and with expansion.
        */
        public string[] getSingles(string database, string table, string expansion)
        {

            string sqlparams = "";
            sqlparams += "server=" + host + ";";
            sqlparams += "user=" + user + ";";
            sqlparams += "database=" + database + ";";
            sqlparams += "port=" + port + ";";
            sqlparams += "password=" + pass + ";";

            MySqlConnection con = new MySqlConnection(sqlparams);

            try
            {

                con.Open();
                MySqlCommand cmd;
                MySqlDataReader rdr;

                string sql;

                sql = "SELECT * FROM " + table + " WHERE expansionName='" + expansion + "'";
                cmd = new MySqlCommand(sql, con);
                rdr = cmd.ExecuteReader();

                string[] singles;
                List<string> singlesList = new List<string>();

                while (rdr.Read())
                {
                    singlesList.Add(Convert.ToString(rdr[2]) + "|" + Convert.ToString(rdr[0]) + "|" + Convert.ToString(rdr[9]));
                }

                singles = singlesList.ToArray();
                var sortedBlocks = singlesList.OrderBy(n => n);

                rdr.Close();
                con.Close();

                return sortedBlocks.ToArray();

            }
            catch (Exception ex)
            {
                con.Close();
                Console.WriteLine(ex);
                return null;
            }

        }

        /*
        * Function that returns singles as single-objects.
        */
        public Single[] getSingles(string database, string table)
        {

            string sqlparams = "";
            sqlparams += "server=" + host + ";";
            sqlparams += "user=" + user + ";";
            sqlparams += "database=" + database + ";";
            sqlparams += "port=" + port + ";";
            sqlparams += "password=" + pass + ";";

            MySqlConnection con = new MySqlConnection(sqlparams);

            try
            {

                con.Open();
                MySqlCommand cmd;
                MySqlDataReader rdr;

                string sql;

                sql = "SELECT * FROM " + table + "";
                cmd = new MySqlCommand(sql, con);
                rdr = cmd.ExecuteReader();

                //Single[] singles;
                List<Single> singlesList = new List<Single>();

                while (rdr.Read())
                {
                    singlesList.Add(new Single(Convert.ToInt32(rdr[0]), Convert.ToInt32(rdr[1]), Convert.ToString(rdr[2]), Convert.ToString(rdr[3]), Convert.ToString(rdr[4]), Convert.ToString(rdr[5]), Convert.ToString(rdr[6]), Convert.ToString(rdr[7]), Convert.ToString(rdr[8]), Convert.ToString(rdr[9])));
                }

                //TODO: Sort
                //singles = singlesList.ToArray();
                //var sortedBlocks = singles.OrderBy(n => n);

                rdr.Close();
                con.Close();

                return singlesList.ToArray();

            }
            catch (Exception ex)
            {
                con.Close();
                Console.WriteLine(ex);
                return null;
            }

        }

        /*
        * Function that inserts the rule into the SQL-database.
        */
        public void insertRule(string blockTarget, string expansionTarget, string singleTarget, string enName, string rarity, int value, string valueSelector, string valueModifier, string cardmarketPrice)
        {

            string sqlparams = "";
            sqlparams += "server=" + host + ";";
            sqlparams += "user=" + user + ";";
            sqlparams += "database=" + "tier1mtg_manager_rules" + "; ";
            sqlparams += "port=" + port + ";";
            sqlparams += "password=" + pass + ";";

            MySqlConnection con = new MySqlConnection(sqlparams);

            try
            {

                con.Open();
                MySqlCommand cmd;
                MySqlDataReader rdr;

                string sql;

                sql = "INSERT INTO manager_rules VALUES ('"+blockTarget+ "', '" + expansionTarget + "', '" + singleTarget + "', '" + enName + "', '" + rarity + "', '" + value + "', '" + valueSelector + "', '" + valueModifier + "', '" + cardmarketPrice + "')";
                cmd = new MySqlCommand(sql, con);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0]);
                }

                con.Close();

            }
            catch (Exception ex)
            {
                con.Close();
                Console.WriteLine(ex);
            }

        }

        /*
        * Function that returns all rules as objects from the rules-table.
        */
        public Rules[] getRules()
        {

            string sqlparams = "";
            sqlparams += "server=" + host + ";";
            sqlparams += "user=" + user + ";";
            sqlparams += "database=" + "tier1mtg_manager_rules" + "; ";
            sqlparams += "port=" + port + ";";
            sqlparams += "password=" + pass + ";";

            MySqlConnection con = new MySqlConnection(sqlparams);

            try
            {

                con.Open();
                MySqlCommand cmd;
                MySqlDataReader rdr;

                string sql;

                sql = "SELECT * FROM manager_rules";
                cmd = new MySqlCommand(sql, con);
                rdr = cmd.ExecuteReader();

                List<Rules> rules = new List<Rules>();

                while (rdr.Read())
                {
                    rules.Add(new Rules(Convert.ToString(rdr[0]), Convert.ToString(rdr[1]), Convert.ToString(rdr[2]), Convert.ToString(rdr[3]), Convert.ToString(rdr[4]), Convert.ToInt32(rdr[5]), Convert.ToString(rdr[6]), Convert.ToString(rdr[7]), Convert.ToString(rdr[8])));
                }

                con.Close();
                return rules.ToArray();

            }
            catch (Exception ex)
            {
                con.Close();
                Console.WriteLine(ex);
                return null;
            }

        }

    }
}
