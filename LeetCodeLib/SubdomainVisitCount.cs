using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class SubdomainVisitCount
    {
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            // "9001 discuss.leetcode.com"
            // com
            // leetcode.com
            // discuss.leetcode.com
            Dictionary<string, int> domainWithCount = new Dictionary<string, int>();
            foreach (var item in cpdomains)
            {
                string[] tmp = item.Split(' ');
                int count = int.Parse(tmp[0]);
                string domain = tmp[1];
                List<string> domains = GetAllDomains(domain);
                foreach (var d in domains)
                {
                    if (!domainWithCount.ContainsKey(d))                    
                        domainWithCount.Add(d, count);
                    else
                        domainWithCount[d] += count;
                }
            }

            List<string> res = new List<string>();
            foreach (var item in domainWithCount)            
                res.Add(item.Value +" "+item.Key);            

            return res;
        }

        private List<string> GetAllDomains(string domain)
        {
            List<string> res = new List<string>();
            List<string> tmp = domain.Split('.').ToList();
            string domains = string.Empty;

            for (int i = 0; i < tmp.Count; i++)
            {
                List<string> current = tmp.GetRange(i, tmp.Count - i);
                domains = string.Join('.', current);
                res.Add(domains);
            }
            return res;
        }
    }
}