using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Current
{
    public string last_updated_epoch;
    public string last_updated;
    public string temp_c;
    public string is_day;
    public Condition condition;
    public string wind_kph;
    public string wind_degree;
    public string pressure_mb;
    public string humidity;
    public string gust_kph;
}
