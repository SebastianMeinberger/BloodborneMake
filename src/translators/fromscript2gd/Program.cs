using System;
using SoulsFormats;
namespace fromscript2gd;

class Program
{
    static void Main(string[] args)
    {
        ESD talk = ESD.Read(@"~/Documents/Bloodborne/chr/c0000.esd.dcx");
    }
}
