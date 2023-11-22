using LeetCodeLib;

namespace LeetCodeTest;

[TestClass]
public class WayFairTest
{
    [TestMethod]
    public void SubdomainVisitsTest1()
    {
        string[] cpdomains = new string[] { "9001 discuss.leetcode.com" };
        List<string> answer = new List<string> { "9001 leetcode.com", "9001 discuss.leetcode.com", "9001 com" };
        SubdomainVisitCount sub = new SubdomainVisitCount();
        IList<string> res = sub.SubdomainVisits(cpdomains);
        
        foreach (var item in res)
            answer.Remove(item);        
        Assert.IsTrue(answer.Count == 0);
    }

     [TestMethod]
    public void SubdomainVisitsTest2()
    {
        string[] cpdomains = new string[] { "900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org" };
        List<string> answer = new List<string> { "901 mail.com","50 yahoo.com","900 google.mail.com","5 wiki.org","5 org","1 intel.mail.com","951 com" };
        SubdomainVisitCount sub = new SubdomainVisitCount();
        IList<string> res = sub.SubdomainVisits(cpdomains);
        
        foreach (var item in res)
            answer.Remove(item);        
        Assert.IsTrue(answer.Count == 0);
    }
}