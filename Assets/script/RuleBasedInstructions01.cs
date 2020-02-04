using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleBasedInstructions01 : MonoBehaviour
{
    public bool rebuild;
    public string[] standPositionOnChessBoard;
  
    public string[] chessPieceColor;
    public int minNumber;
    public int maxNumber;
    public string[] chessPositionOnChessBoard;

    public string[] skittlesColor;
    public int minNumber02;
    public int maxNumber02;
    public string[]  candyPositionOnChessBoard;

    void Start()
    {

    }

    void Update()
    {
        if(rebuild){
          
            string output = "Put two Chess boxes, ";

            string sPOCBoard = standPositionOnChessBoard[Random.Range(0,standPositionOnChessBoard.Length)];

            output += sPOCBoard + " of the board.\nChoose ";

            int howMany = Random.Range(minNumber, maxNumber);
            string cPColor = chessPieceColor[Random.Range(0,chessPieceColor.Length)];

            output += howMany + " " + cPColor + " Chesses, place them ";

            string chessPOCBoard = chessPositionOnChessBoard[Random.Range(0,chessPositionOnChessBoard.Length)];
          
            output += chessPOCBoard + " of the board.\nAnd choose ";

            howMany *= 2;
            output += howMany + " " + cPColor + " Chesses, " + chessPOCBoard + " of the board.";

            int Several = Random.Range(minNumber02,maxNumber02);
            string sColor = skittlesColor[Random.Range(0,skittlesColor.Length)];
            string candyPOCBoard = candyPositionOnChessBoard[Random.Range(0,candyPositionOnChessBoard.Length)];

            output += "\nThen, get " + Several + " piece of skittles, put them " + candyPOCBoard + ".";

            Debug.Log(output);

            rebuild = false;
        
        }
    }
}
