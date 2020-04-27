﻿using GitTestavimuisi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestavimuisi
{
    interface IDuomenys
    {
        int Id { get; set; }
        string Zinute { get; set; }
        DateTime DuomenuParuososLaikas { get; set; }

    }

    interface IKomunikacija
    {
        void Siusti(string zinute);
        string SkaitytiDuomenis();
        void PakartotiPaskutineZinute();
    }

    interface IDuomenu_paruosimas
    {
        List<IDuomenys> Data { get; }

        string SukurtiDuomenuEilute(IDuomenys duomuo);

        void PridetiDuomeni(IDuomenys duomuo);

        void SiustiPirmaDuomeni();

        void SiustiDuomeni(int kelintas);

        void SiustiPaskutinDuomeni();
    }
}

class gDuomenys : IDuomenys
{
    public int Id { get ; set ; }
    public string Zinute { get; set ; }
    public DateTime DuomenuParuososLaikas { get ; set ; }
}

class gKomunikacija : IKomunikacija
{
    public void PakartotiPaskutineZinute()
    {
        
    }

    public void Siusti(string zinute)
    {
       
    }

    public string SkaitytiDuomenis()
    {
        string a = "df";
        return a;
    }
}

class gDuomenu_paruosimas : IDuomenu_paruosimas
{
    public List<IDuomenys> Data => throw new NotImplementedException();

    public void PridetiDuomeni(IDuomenys duomuo)
    {
       
    }

    public void SiustiDuomeni(int kelintas)
    {
        
    }

    public void SiustiPaskutinDuomeni()
    {
       
    }

    public void SiustiPirmaDuomeni()
    {
        
    }

    public string SukurtiDuomenuEilute(IDuomenys duomuo)
    {
        string a = "df";
        return a;
    }
}
