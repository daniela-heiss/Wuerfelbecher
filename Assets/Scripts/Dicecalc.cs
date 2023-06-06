using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceCalc : MonoBehaviour
{
    public int diceType;
    //public static bool startCalc;
    public int upperVal;
    
    void Start()
    {
        //startCalc = false;
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
            } else if (this.transform.eulerAngles.z > 260 && this.transform.eulerAngles.z < 280){
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

    public void findUpperVal(){
        switch(diceType) {
            case 4:
               InvokeRepeating("d4Calc", 0.0f, 1.0f);
            break;
            case 6:
                InvokeRepeating("d6Calc", 0.0f, 1.0f);
            break;
            case 8:
                InvokeRepeating("d8Calc", 0.0f, 1.0f);
            break;
            case 101:
                InvokeRepeating("d101Calc", 0.0f, 1.0f);
            break;
            case 102:
                InvokeRepeating("d102Calc", 0.0f, 1.0f);
            break;
        }
    }
}
