using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApplication
{
    public class Friends
    {
        public string quote { get; set; }
        public string character { get; set; }
        public string InputValue { get; set; } // Input value for character filter and keyword filter
        private bool isSortedAscending;
        private string activeSortColumn;
        public List<Friends> listOfQuotes;

        public void SortTable(string columnName)
        {
            // Checking for the current activeSortColumn name clicked on
            if (columnName != activeSortColumn)
            {
                // If the column name is not equals to the active column name 
                // Then order the list collection from ascending to descending
                listOfQuotes = listOfQuotes.OrderBy(name => name.character).ToList();

                // Set the isSortedAscending to true 
                isSortedAscending = true;

                // Set the activeSortColumn to the passed in column name 
                activeSortColumn = columnName;
            }
            // If the column name is already == activeSortColumn 
            else
            {
                // If the column is already sorted
                if (isSortedAscending)
                {
                    // Then have the list collection in descending order
                    listOfQuotes = listOfQuotes.OrderByDescending(name => name.character).ToList();
                }
                else
                {
                    listOfQuotes = listOfQuotes.OrderBy(name => name.character).ToList();
                }
                // Reset sorting 
                isSortedAscending = !isSortedAscending;
            }
        }

        public bool IsVisible(Friends friends)
        {
            if (string.IsNullOrEmpty(InputValue))
                return true;

            // Checks if the input value matches any value within the collection and ignoring the letter case sensitive
            if (friends.character.Contains(InputValue, StringComparison.OrdinalIgnoreCase))
                return true;

            if (friends.quote.Contains(InputValue, StringComparison.OrdinalIgnoreCase))
                return true;

            return false;
        }
    }
}
