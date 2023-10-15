using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_file_converter
{
    /// <summary>
    /// This class contains functionality to convert a give CSV file (as List<string>) to
    /// SQL clauses, using an SQL template clause with placeholders indicating CSV fields
    /// </summary>
    internal class CSVtoSQLconvert
    {
        public List<string> ConvertToSQL(
            List<string> sourceFile, 
            string SQLTemplate, 
            bool hasHeaderRow, 
            bool mustHaveValues,
            string separatorCharacter, 
            int rowsBetweenGo)
        {

            //if (!SQLTemplate.EndsWith(";"))
            //    SQLTemplate += ";";

            List<string> placeHolders = GetPlaceHolders(SQLTemplate);

            // This is the list that will be returned
            List<string> sqlClauses = new List<string>();

            bool addRow;

            int totalRowCount = 0;       // All rows
            int rowBatchCounter = 0; // Added rows

            foreach (string line in sourceFile)
            {
                if (hasHeaderRow == false || totalRowCount > 0)  // Skip header if so selected
                {
                    // Split the line into parts using the separator character:
                    string[] fields = line.Split(separatorCharacter);

                    // If we want to check that all fields contain values, analyze the field now:
                    addRow = true; // Default to yes, change to false if there isn't a value in some field OR not enough fields
                    if (mustHaveValues)
                    {
                        foreach (string fieldNumber in placeHolders)
                        {
                            // fieldNumber - check that there are at least that many fields (0 based); if yes
                            int fieldNumberInt = Convert.ToInt32(fieldNumber);

                            // Enough fields?
                            if (fields.Length < (fieldNumberInt + 1))
                                addRow = false;  // Wanted index is larger than number of fields on this row
                            else
                                if (string.IsNullOrWhiteSpace(fields[fieldNumberInt]))
                                addRow = false;  // There is no value in the field
                        }
                    }

                    // Go through all items in placeHolder, replacing values in 
                    if (addRow)
                    {
                        string tmpSQL = SQLTemplate;
                        foreach (string fieldNumber in placeHolders)
                        {
                            string tmpPlaceholder = "{" + fieldNumber + "}";
                            int fieldNumberInt = Convert.ToInt32(fieldNumber);

                            // Remove leading and trailing whitespace. Escape singe quotes to double single quotes. Remove leading and trailing double quotes
                            string tmpFieldValue = fields[fieldNumberInt].Trim().Replace("'", "''").Trim('"');
                            tmpSQL = tmpSQL.Replace(tmpPlaceholder, tmpFieldValue);

                            rowBatchCounter++;
                        }

                        // Add the generated SQL clause:
                        sqlClauses.Add(tmpSQL);
                    }
                }
                totalRowCount++;

                // Should we commit
                if (rowBatchCounter == rowsBetweenGo)
                {
                    sqlClauses.Add("go");
                    rowBatchCounter = 0;
                }

            }

            return sqlClauses;
        }


        /// <summary>
        /// Check all possible placeholders ({0}..{100}) and make a list of them
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private List<string> GetPlaceHolders(string sql)
        {
            List<string> tmpList = new List<string>();

            // Generate placholders 0 - 100 and check if they exist in the SQL Clause. If yes, add to list
            for (int i = 0; i <= 100; i++)
            {
                string placeHolder = "{" + i.ToString() + "}";
                if (sql.Contains(placeHolder))
                    tmpList.Add(i.ToString());
            }

            return tmpList;
        }
    }
}
