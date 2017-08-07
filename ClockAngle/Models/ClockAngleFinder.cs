using System;
using System.Collections.Generic;

namespace ClockAngle.Models
{
  public class ClockAngleFinder
  {
    private int _hour;
    private int _minute;

    public ClockAngleFinder(int hour, int minute)
    {
      _hour = hour;
      _minute = minute;
    }
    public int GetHour()
    {
      return _hour;
    }
    public int GetMinute()
    {
      return _minute;
    }

    public int ReturnDegrees()
    {
      //return smallese distance in degrees between hour and minute clock hands
      int degreesHour = 0;
      int degreesMinute = 0;
      if (_hour != 12)
      {
        degreesHour = _hour*30;
      }
      else
      {
        degreesHour = 0;
      }
      if (_minute !=12)
      {
        degreesMinute = _minute*6;
      }
      else
      {
        degreesMinute = 0;
      }

      return Math.Abs(degreesHour - degreesMinute);

    }
  }
}
