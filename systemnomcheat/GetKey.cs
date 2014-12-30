using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemnomcheat
{
    class GetKey
    {
        public static char Get(int nrkey)
        {
            char key = '2';

            switch (nrkey)
            {
                case 0:
                    key = 'q';
                    break;
                case 1:
                    key = 'w';
                    break;
                case 2:
                    key = 'e';
                    break;
                case 3:
                    key = 'r';
                    break;
                case 4:
                    key = 't';
                    break;
                case 5:
                    key = 'y';
                    break;
                case 6:
                    key = 'u';
                    break;
                case 7:
                    key = 'i';
                    break;
                case 8:
                    key = 'o';
                    break;
                case 9:
                    key = 'p';
                    break;
                case 10:
                    key = 'a';
                    break;
                case 11:
                    key = 's';
                    break;
                case 12:
                    key = 'd';
                    break;                    
                case 13:
                    key = 'f';
                    break;
                case 14:
                    key = 'g';
                    break;
                case 15:
                    key = 'h';
                    break;                    
                case 16:
                    key = 'j';
                    break;
                case 17:
                    key = 'k';
                    break;
                case 18:
                    key = 'l';
                    break;
                case 19:
                    key = 'z';
                    break;
                case 20:
                    key = 'x';
                    break;
                case 21:
                    key = 'c';
                    break;
                case 22:
                    key = 'v';
                    break;
                case 23:
                    key = 'b';
                    break;
                case 24:
                    key = 'n';
                    break;
                case 25:
                    key = 'm';
                    break;
                default:
                    key = '1';
                    break;
            }
        

            return key;
        }

    }
}
