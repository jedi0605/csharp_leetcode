using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class InhreternClass
    {

    }

    public class Box0
    {
        public virtual string GetText()
        {
            return "Box0";
        }
    }

    public class Box1 : Box0
    {
        public override string GetText()
        {
            return "Box0";
        }
    }

    public class Box2 : Box1
    {
        public override string GetText()
        {
            return "Box2";
        }
    }
}