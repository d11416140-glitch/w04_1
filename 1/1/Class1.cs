using System;

public class test
{
    private int mid;
    private const int final=99;


    public int mymid { get; } = 56;
    public int myfinal
    {
        get
        {
            return final;

        }
        set
        {
            if (value > 0 && value < 100)
            {
                //final = value;
            }
            else
            {
                //final = 0;
            }
        }
    }
}

