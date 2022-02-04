using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 石头剪刀布
{
    public enum Result
    {
        玩家赢,
        电脑赢,
        平局
    }
    class CaiPan
    {
        public static Result Judge(int playerNumber,int computerNumber)
        {
            if(playerNumber-computerNumber==-1||playerNumber-computerNumber==2)
            {
                return Result.玩家赢;
            }else if(playerNumber-computerNumber==0)
            {
                return Result.平局;
            }
            else
            {
                return Result.电脑赢;
            }
        }
    }
}
