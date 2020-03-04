using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessChecker
{
	class Worker
	{
		ChessPiece chessPiece = null;
		string[,] board = new String[8, 8];

		public void Start()
		{
			board[1, 1] = "K";
			//int distX = 0;
			//int distY = 0;
			//int vectX = 0;
			//int vectY = 0;
			int posX = 1;
			int posY = 7;
			int newPosX = 1;
			int newPosY = 1;
			CheckDirection(posX, posY, newPosX, newPosY);
		}

		public bool checkPiece(int posX, int posY, int newPosX, int newPosY)
		{
			int distX = newPosX - posX;
			int distY = newPosY - posY;
			int vectX = CreateVector(distX);
			int vectY = CreateVector(distY);



			return false;
		}

		public bool CheckDirection(int posX, int posY, int newPosX, int newPosY)
		{
			int distX = newPosX - posX;
			int distY = newPosY - posY;
			int vectX = CreateVector(distX);
			int vectY = CreateVector(distY);

			bool res = false;
			int x = posX;
			int y = posY;
			
				Console.WriteLine($"\nChessPiece: {board[x,y]}\nX = {x}\nY = {y}\nvectY = {vectX}\nvectY = {vectY}");
			while (x != newPosX || y != newPosY)
			{
				x = x + vectX;
				y = y + vectY;
				Console.WriteLine($"\nChecking {x} , {y}\nChessPiece: {board[x,y]}");

				//chessPiece = CheckSquare(x, y);

				res = CheckSquare(x, y);
				if (res == true)
				{
				return res;
				}

			}
			//	1: if (Math.abs(distY) == Math.abs(distY) || vectX == 0 || vectY == 0)

			return res;
		}

		bool CheckSquare(int x, int y)
		{
			bool res = board[x,y] == "K";
			//ChessPiece chessPiece = ChessBoard.GetChessPiece(x, y);
			return res;
		}

		int CreateVector(int dist)
		{
			int vect = 0;
			if (dist != 0)
			{
				vect = dist / Math.Abs(dist);
			}
			return vect;
		}



	}
}
