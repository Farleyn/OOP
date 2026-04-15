using System;

namespace ConsoleApp1
{
    public enum TööTüüp
    {
        Palk, 
        Toetus
    }
    public interface ITööline
    {
        TööTüüp VäljamakseTüüp { get; set; }
        double ArvutaPalk();
    }
}