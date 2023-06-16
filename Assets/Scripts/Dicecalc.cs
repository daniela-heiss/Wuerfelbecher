using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceCalc : MonoBehaviour
{
    public int diceType;
    public int upperVal;
    
    void Start()
    {
        upperVal = 0;
    }

    void d4Calc(){
        if (350 < this.transform.eulerAngles.x || this.transform.eulerAngles.x < 10)
        {
                    if (350 < this.transform.eulerAngles.z || this.transform.eulerAngles.z < 10){
                        upperVal = 1;
                    } else if (this.transform.eulerAngles.z > 240 && this.transform.eulerAngles.z < 260){
                        upperVal = 2;
                    }
               } else if (this.transform.eulerAngles.z > 115 && this.transform.eulerAngles.z < 135){
                    if (this.transform.eulerAngles.x > 295 && this.transform.eulerAngles.x < 315){
                        upperVal = 3;
                    } else if(this.transform.eulerAngles.x > 45 && this.transform.eulerAngles.x < 65){
                        upperVal = 4;
                    }
               } else {
                upperVal = 0;
        }
    }

    void d6Calc(){
        if (350 < this.transform.eulerAngles.x || this.transform.eulerAngles.x < 10){
            if(350 < this.transform.eulerAngles.z || this.transform.eulerAngles.z < 10){
                upperVal = 1;
            } else if (this.transform.eulerAngles.z > 80 && this.transform.eulerAngles.z < 100){
                upperVal = 3;
            } else if (this.transform.eulerAngles.z > 260 && this.transform.eulerAngles.z < 280){
                upperVal = 4;
            } else if (this.transform.eulerAngles.z > 170 && this.transform.eulerAngles.z < 190){
                upperVal = 6;
            }
        } else if (350 < this.transform.eulerAngles.z || this.transform.eulerAngles.z < 10){
            if(this.transform.eulerAngles.x > 80 && this.transform.eulerAngles.x < 100){
                upperVal = 2;
            } else if (this.transform.eulerAngles.x > 260 && this.transform.eulerAngles.x < 280){
                upperVal = 5;
            }
        } else {
            upperVal = 0;
        }
    }

    void d8Calc(){
        if (350 < this.transform.eulerAngles.x || this.transform.eulerAngles.x < 10){
            if (this.transform.eulerAngles.z > 280 && this.transform.eulerAngles.z < 300){
                upperVal = 2;
            } else if (this.transform.eulerAngles.z > 170 && this.transform.eulerAngles.z < 190){
                upperVal = 3;
            } else if (350 < this.transform.eulerAngles.z || this.transform.eulerAngles.z < 10){
                upperVal = 6;
            } else if (this.transform.eulerAngles.z > 100 && this.transform.eulerAngles.z < 120){
                upperVal = 7;
            } 
        } else if (this.transform.eulerAngles.z > 45 && this.transform.eulerAngles.z < 65){
            if (this.transform.eulerAngles.x > 45 && this.transform.eulerAngles.x < 65){
                upperVal = 1;
            } else if(this.transform.eulerAngles.x > 295 && this.transform.eulerAngles.x < 315){
                upperVal = 5;
            }
        } else if (this.transform.eulerAngles.z > 225 && this.transform.eulerAngles.z < 245){
            if (this.transform.eulerAngles.x > 45 && this.transform.eulerAngles.x < 65){
                upperVal = 4;
            } else if (this.transform.eulerAngles.x > 295 && this.transform.eulerAngles.x < 315){
                upperVal = 8;
            }
        } else {
            upperVal = 0;
        }
    }

    void d101Calc(){
        if(350 < this.transform.eulerAngles.x || this.transform.eulerAngles.x < 10){
            if (350 < this.transform.eulerAngles.z || this.transform.eulerAngles.z < 10){
                upperVal = 1;
            } else if (this.transform.eulerAngles.z > 170 && this.transform.eulerAngles.z < 190){
                upperVal = 10;
            }
        } else if (this.transform.eulerAngles.x > 10 && this.transform.eulerAngles.x < 30){
            if (this.transform.eulerAngles.z > 301 && this.transform.eulerAngles.z < 321){
                upperVal = 7;
            } else if (this.transform.eulerAngles.z > 39 && this.transform.eulerAngles.z < 59){
                upperVal = 9;
            }
        } else if (this.transform.eulerAngles.x > 330 && this.transform.eulerAngles.x < 350){
            if (this.transform.eulerAngles.z > 219 && this.transform.eulerAngles.z < 239){
                upperVal = 2;
            } else if (this.transform.eulerAngles.z > 121 && this.transform.eulerAngles.z < 141){
                upperVal = 4;
            }
        } else if (this.transform.eulerAngles.z > 80 && this.transform.eulerAngles.z < 100){
            if (this.transform.eulerAngles.x > 54 && this.transform.eulerAngles.x < 74){
                upperVal = 5;
            } else if (this.transform.eulerAngles.x > 286 && this.transform.eulerAngles.x < 306){
                upperVal = 8;
            }
        } else if (this.transform.eulerAngles.z > 260 && this.transform.eulerAngles.z < 280){
            if (this.transform.eulerAngles.x > 54 && this.transform.eulerAngles.x < 74){
                upperVal = 3;
            } else if (this.transform.eulerAngles.x > 286 && this.transform.eulerAngles.x < 306){
                upperVal = 6;
            }
        } else {
            upperVal = 0;
        }
    }

    void d102Calc(){
        if(350 < this.transform.eulerAngles.x || this.transform.eulerAngles.x < 10){
            if (350 < this.transform.eulerAngles.z || this.transform.eulerAngles.z < 10){
                upperVal = 10;
            } else if (this.transform.eulerAngles.z > 170 && this.transform.eulerAngles.z < 190){
                upperVal = 0;
            }
        } else if (this.transform.eulerAngles.x > 10 && this.transform.eulerAngles.x < 30){
            if (this.transform.eulerAngles.z > 301 && this.transform.eulerAngles.z < 321){
                upperVal = 70;
            } else if (this.transform.eulerAngles.z > 39 && this.transform.eulerAngles.z < 59){
                upperVal = 90;
            }
        } else if (this.transform.eulerAngles.x > 330 && this.transform.eulerAngles.x < 350){
            if (this.transform.eulerAngles.z > 219 && this.transform.eulerAngles.z < 239){
                upperVal = 20;
            } else if (this.transform.eulerAngles.z > 121 && this.transform.eulerAngles.z < 141){
                upperVal = 40;
            }
        } else if (this.transform.eulerAngles.z > 80 && this.transform.eulerAngles.z < 100){
            if (this.transform.eulerAngles.x > 54 && this.transform.eulerAngles.x < 74){
                upperVal = 50;
            } else if (this.transform.eulerAngles.x > 286 && this.transform.eulerAngles.x < 306){
                upperVal = 80;
            }
        } else if (this.transform.eulerAngles.z > 260 && this.transform.eulerAngles.z < 280){
            if (this.transform.eulerAngles.x > 54 && this.transform.eulerAngles.x < 74){
                upperVal = 30;
            } else if (this.transform.eulerAngles.x > 286 && this.transform.eulerAngles.x < 306){
                upperVal = 60;
            }
        } else {
            upperVal = 0;
        }
    }

    void d12Calc(){
        if(this.transform.eulerAngles.x > 304 && this.transform.eulerAngles.x < 324){
            if(this.transform.eulerAngles.z > 120 && this.transform.eulerAngles.z < 140){
                upperVal = 1;
            } else if (this.transform.eulerAngles.z > 220 && this.transform.eulerAngles.z < 240){
                upperVal = 5;
            }
        } else if (this.transform.eulerAngles.x > 334 && this.transform.eulerAngles.x < 354){
            if(this.transform.eulerAngles.z > 288 && this.transform.eulerAngles.z < 308){
                upperVal = 2;
            } else if (this.transform.eulerAngles.z > 42 && this.transform.eulerAngles.z < 72){
                upperVal = 9;
            }
        } else if(this.transform.eulerAngles.x > 6 && this.transform.eulerAngles.x < 26){
            if(this.transform.eulerAngles.z > 232 && this.transform.eulerAngles.z < 252){
                upperVal = 4;
            } else if (this.transform.eulerAngles.z > 108 && this.transform.eulerAngles.z < 128){
                upperVal = 11;
            }
        } else if(this.transform.eulerAngles.x > 36 && this.transform.eulerAngles.x < 56){
            if(this.transform.eulerAngles.z > 40 && this.transform.eulerAngles.z < 60){
                upperVal = 8;
            } else if (this.transform.eulerAngles.z > 300 && this.transform.eulerAngles.z < 320){
                upperVal = 12;
            }
        } else if (350 < this.transform.eulerAngles.z || this.transform.eulerAngles.z < 10){
            if(350 < this.transform.eulerAngles.x || this.transform.eulerAngles.x < 10){
                upperVal = 6;
            } else if (this.transform.eulerAngles.x > 287 && this.transform.eulerAngles.x < 307){
                upperVal = 10;
            }
        } else if (this.transform.eulerAngles.z > 170 && this.transform.eulerAngles.z < 190){
            if(350 < this.transform.eulerAngles.x || this.transform.eulerAngles.x < 10){
                upperVal = 7;
            } else if (this.transform.eulerAngles.x > 53 && this.transform.eulerAngles.x < 73){
                upperVal = 3;
            }
        } else {
            upperVal = 0;
        }
    }

    void d20Calc(){
        if (350 < this.transform.eulerAngles.x || this.transform.eulerAngles.x < 10){
            if (this.transform.eulerAngles.z > 170 && this.transform.eulerAngles.z < 190){
                upperVal = 1;
            } else if (this.transform.eulerAngles.z > 128 && this.transform.eulerAngles.z < 138){
                upperVal = 7;
            } else if (this.transform.eulerAngles.z > 308 && this.transform.eulerAngles.z < 328){
                upperVal = 14;
            } else if (350 < this.transform.eulerAngles.z || this.transform.eulerAngles.z < 10){
                upperVal = 20;
                //crit = true
            }
        } else if (this.transform.eulerAngles.x > 25 && this.transform.eulerAngles.x < 45){
            if (this.transform.eulerAngles.z > 14 && this.transform.eulerAngles.z < 34){
                upperVal = 2;
            } else if (this.transform.eulerAngles.z > 284 && this.transform.eulerAngles.z < 304){
                upperVal = 4;
            } else if (this.transform.eulerAngles.z > 194 && this.transform.eulerAngles.z < 214){
                upperVal = 13;
            } else if (this.transform.eulerAngles.z > 104 && this.transform.eulerAngles.z < 124){
                upperVal = 15;
            } 
        } else if (this.transform.eulerAngles.x > 315 && this.transform.eulerAngles.x < 335){
            if (this.transform.eulerAngles.z > 284 && this.transform.eulerAngles.z < 304){
                upperVal = 6;
            } else if (this.transform.eulerAngles.z > 14 && this.transform.eulerAngles.z < 38){
                upperVal = 8;
            } else if (this.transform.eulerAngles.z > 104 && this.transform.eulerAngles.z < 124){
                upperVal = 17;
            } else if (this.transform.eulerAngles.z > 194 && this.transform.eulerAngles.z < 114){
                upperVal = 19;
            }
        } else if (this.transform.eulerAngles.x > 11 && this.transform.eulerAngles.x < 31){
            if (this.transform.eulerAngles.z > 281 && this.transform.eulerAngles.z < 301){
                upperVal = 11;
            } else if (this.transform.eulerAngles.z > 59 && this.transform.eulerAngles.z < 79){
                upperVal = 12;
            } 
        } else if (this.transform.eulerAngles.x > 329 && this.transform.eulerAngles.x < 349){
            if (this.transform.eulerAngles.z > 239 && this.transform.eulerAngles.z < 259){
                upperVal = 9;
            } else if (this.transform.eulerAngles.z > 59 && this.transform.eulerAngles.z < 79){
                upperVal = 10;
            } 
        } else if (this.transform.eulerAngles.z > 149 && this.transform.eulerAngles.z < 169){
            if (this.transform.eulerAngles.x > 281 && this.transform.eulerAngles.x < 301){
                upperVal = 3;
            } else if (this.transform.eulerAngles.x > 59 && this.transform.eulerAngles.x < 79){
                upperVal = 5;
            } 
        } else if (this.transform.eulerAngles.z > 329 && this.transform.eulerAngles.z < 349){
            if (this.transform.eulerAngles.x > 281 && this.transform.eulerAngles.x < 301){
                upperVal = 16;
            } else if (this.transform.eulerAngles.x > 59 && this.transform.eulerAngles.x < 79){
                upperVal = 18;
            } 
        } 
    }

    public void findUpperVal(){
        switch(diceType) {
            case 4:
               InvokeRepeating("d4Calc", 0.0f, 2.0f);
            break;
            case 6:
                InvokeRepeating("d6Calc", 0.0f, 2.0f);
            break;
            case 8:
                InvokeRepeating("d8Calc", 0.0f, 2.0f);
            break;
            case 101:
                InvokeRepeating("d101Calc", 0.0f, 2.0f);
            break;
            case 102:
                InvokeRepeating("d102Calc", 0.0f, 2.0f);
            break;
            case 12:
                InvokeRepeating("d12Calc", 0.0f, 2.0f);
            break;
            case 20:
                InvokeRepeating("d20Calc", 0.0f, 2.0f);
            break;
        }
    }
}
