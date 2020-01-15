using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace QuanLyPhongKham
{
    internal class StringSearch
    {
        private string strSearch;
        private string[] keywords;

        public StringSearch(string v)
        {
            this.strSearch = v;
            NormalizeString();
            createKeyword();

        }

        private void createKeyword()
        {
            int n;
            bool isNumberic = int.TryParse(strSearch, out n);
            bool anyNumber = strSearch.Any(char.IsDigit);
            bool anySymbol = strSearch.Any(char.IsSymbol);
            bool anyWhiteSpace = strSearch.Any(char.IsWhiteSpace);
            if (isNumberic)
            {
                keywords = new string[] { "phonenumber" };
                return;
            }
            if (anyWhiteSpace)
            {
                if (anyNumber)
                    keywords = new string[] { "address" };
                else
                    keywords = new string[] { "name" };
                return;
            }
            keywords = new string[] { "profilecode" };
        }

        private void NormalizeString()
        {
            this.strSearch = removeDiacritics(this.strSearch);
            this.strSearch.ToLower();
        }

        private string removeDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        public string[] getKeywords()
        {
            return this.keywords;
        }

        public string getSearchString()
        {
            return this.strSearch;
        }
    }
}