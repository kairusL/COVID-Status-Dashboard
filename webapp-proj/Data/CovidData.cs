using System;
namespace webapp_proj.Models
{

public class CovidData
{
    public string Province{get;set;}
    public long Cumulative_Case{get;set;}// total case
    public long Cases{get;set;} // new change
    public long ActiveCases{get;set;} // total active case
    public long ActiveCasesChange{get;set;} //active case change
    public long Cumulative_Deaths{get;set;} //total deaths
    public long Deaths{get;set;}// new deaths data
    public long Cumulative_Recovered{get;set;}// total recovered
    public long Recovered{get;set;}// new Recovered

    public long Cumulative_Testing{get;set;} // total testing
    public long Testing{get;set;} // new testing
    public long Vaccine_Doses{get;set;} // new Vaccine doses administered "avaccine"
    public long Cumulative_Vaccine_Doses{get;set;} // Cumulative Vaccine doses administered "cumulative_avaccine"
    public long P_Vaccinated{get;set;} // People Fully Vaccinated new"cvaccine"
    public long Cumulative_Vaccinated{get;set;} //Cumulative People Fully Vaccinated new"cumulative_cvaccine"








    
}
}