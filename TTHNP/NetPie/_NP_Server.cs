/////////////////////////////////////////
//        TTHNetPie vTTHMain1.0
// Author: Pie
// Version: TTHMain 1.0
// Copyright: TTH2020
// Creation date: 10/26/2020
// Module: NetPie
// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// _NP_Server.cs: Access TTH network
////////////////////////////////////

using Colorful;

namespace NetPie
{
    interface NetServer_I
    {
        bool RunServer();
    }

    public abstract class NetServer : NetServer_I
    {
        protected int _x = 100;
        public abstract bool RunServer();   // Abstract method
        public abstract int X    { get; }
    }

   
    public partial class NetPieApp : NetServer
    {
        protected NetPieApp(int startFlag)
        {
            RunServer();
        }
        public sealed override bool RunServer()
        { 
            Console.WriteLine(_x);
            return true;
        }

        public override int X   // overriding property
        {
            get
            {
                return _x + 10;
            }
        }
     
    }
}