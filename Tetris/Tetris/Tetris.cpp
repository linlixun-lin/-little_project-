#include<conio.h>
#include<cstdlib>
#include<ctime>
#include<graphics.h>
#include<iostream>
#include<windows.h>
#define GRID_SIZE 20
const int winHeight = 800, winWidth = 400;
int blockX = 4, blockY = 0;
int Block[4][4] = { 0 };
const int mapX = winWidth / GRID_SIZE;
const int mapY = winHeight / GRID_SIZE;
int map[mapY] [mapX] = { 0 };
int score = 0;
int shape[7][4][4] = {//1
{
	{0,1,1,0},
	{0,1,1,0},
	{0,0,0,0},
	{0,0,0,0}
},
{
	//const int Lshape[4][4] = {//2
		{0,1,0,0},
		{0,1,0,0},
		{0,1,0,0},
		{0,1,1,0}
	},
	{
		//const int Ishape[4][4] = {//3
			{0,0,1,0},
			{0,0,1,0},
			{0,0,1,0},
			{0,0,1,0}
		},
		{
			//const int Sshape[4][4] = {//4
				{0,1,0,0},
				{0,1,1,0},
				{0,0,1,0},
				{0,0,0,0}
			},
			{
				//const int Tshape[4][4] = {//5
					{0,1,0,0},
					{1,1,1,0},
					{0,0,0,0},
					{0,0,0,0}
				},
				{
					//const int fanLshape[4][4] = {//6
						{0,0,1,0},
						{0,0,1,0},
						{0,0,1,0},
						{0,1,1,0}
					},
					{
						//const int fanSshape[4][4] = {//7
							{0,0,1,0},
							{0,1,1,0},
							{0,1,0,0},
							{0,0,0,0}
						}
};

int randNumber() {
	/*srand((unsigned int)time(NULL));*/
	int shapeIndex = rand() % 7 ;
	return shapeIndex;
}
//void blockBegin() {
//	 blockX 
//	 blockY 
//}
void drawMap() {
	for (int i = 0; i < mapY ; i++) {
		for (int j = 0; j < mapX ; j++) {
			setfillcolor(BLACK);
			int x1 =  j * GRID_SIZE;
			int y1 =  i * GRID_SIZE;
			int x2 = x1 + GRID_SIZE;
			int y2 = y1 + GRID_SIZE;
			solidrectangle(x1, y1, x2, y2);
			if (map[i][j] != 0) {
				setfillcolor(BLUE);
				solidrectangle(x1, y1, x2, y2);
				setcolor(LIGHTGRAY);
				rectangle(x1, y1, x2, y2);
			}
		}
	}
	settextcolor(WHITE);
	char scoreText[30];
	sprintf_s(scoreText, "Score: %d", score);
	outtextxy(winWidth-120,20,scoreText[30]);
}
void createBlock(){
	int shape1 = randNumber();
	for (int i = 0; i < 4; i++) {
		for (int j = 0; j < 4; j++) {
			 Block[i][j] = shape[shape1][i][j];
			 blockX = 4;
			 blockY = 0;
		}
	}
}
void drawBlock() {
	setfillcolor(BLUE);
	for (int i = 0; i <4 ; i++) {
		for (int j = 0; j < 4; j++) {
			if (Block[i][j] == 1) {
				int x1 = (blockX + j) * GRID_SIZE;
				int y1 = (blockY + i) * GRID_SIZE;
				int x2 = x1 + GRID_SIZE ;
				int y2 = y1 + GRID_SIZE ;
				solidrectangle(x1, y1, x2, y2);
				setcolor(LIGHTGRAY);
				rectangle(x1, y1, x2, y2);
			}
		}
	}

}
void clearBlock() {
	setfillcolor(BLACK);
	for (int i = 0; i < 4; i++) {
		for (int j = 0; j <4; j++) {
			if (Block[i][j] == 1) {
				int x1 = (blockX + j) * GRID_SIZE;
				int y1 = (blockY + i) * GRID_SIZE;
				int x2 = x1 + GRID_SIZE;
				int y2 = y1 + GRID_SIZE;
				solidrectangle(x1, y1, x2, y2);
			}
		}
	}
}
bool collision() {
	for (int i = 0; i < 4; i++) {
		for (int j = 0; j < 4; j++) {
			if (Block[i][j] == 1) {
				int Row = blockY + i;
				int Col = blockX + j;
				if (Row >= mapY) {
					return true;
				}
				if (Col < 0 || Col >= mapX) {
					return true;
				}
				if (Row >= 0 && map[Row][Col] != 0) {
					return true;
				}

			}
		}
	}
	return false;
}
void fixBlock() {
	for (int i = 0; i < 4; i++) {
		for (int j = 0; j < 4; j++) {
			if (Block[i][j] == 1) {
				int Row = blockY + i;
				int Col = blockX + j;
				if (Row >= 0 && Row <= mapY-1 && Col >=0 && Col <= mapX-1) {
					map[Row][Col] = 1;
				}
			}
		}
	}

}
void checkFull() {
	int fullCount = 0;
	for (int row = mapY - 1; row >= 0; row--) {
		bool isFull = true;
		for (int col = 0; col < mapX; col++) {
			if (map[row][col] == 0) {
				isFull = false;
				break;
			}
		}
		if (isFull) {
			fullCount++;
			for (int r = row; r > 0; r--) {
				memcpy(map[r], map[r - 1], sizeof(int) * mapX);
			}
			memset(map[0], 0, sizeof(int) * mapX);
			row++;
		}
	}
	score += fullCount * 100;
}

void fallBlock() {
	clearBlock();
	blockY += 1;
	if (collision()) {
		blockY -= 1;
		fixBlock();
		checkFull();
		createBlock();
		if (collision()) {
			MessageBox(GetHWnd(), L"GAME OVER!",L"提示", MB_OK);
			closegraph();
			exit(0);
		}
	}
	drawBlock();
}
bool rotate() {
	clearBlock();
	int backupBlock[4][4];
	int rotatedBlock[4][4];
	int backupBlockX = blockX;
	memcpy(backupBlock, Block, sizeof(int) * 4 * 4);
	memcpy(rotatedBlock, Block, sizeof(int) * 4 * 4);
	for (int i = 0; i < 4; i++) {
		for (int j = 0; j < 4; j++) {
			rotatedBlock[j][3 - i] = Block[i][j];
		}
	}
	memcpy(Block, rotatedBlock, sizeof(int) * 4 * 4);
	if (collision()) {
		blockX++;
		if (collision()) {
			blockX -= 2;
			if (collision()) {
				memcpy(Block, backupBlock, sizeof(int) * 4 * 4);
				blockX = backupBlockX;
				return false;
			}
		}
	}
	clearBlock();
	drawBlock();
	return true;
}
void move() {
	/*if (_kbhit()) {
		char key = _getch();
		while (_kbhit()) {
			_getch();
		}*/
	if ((GetAsyncKeyState('a') & 0x8000)!= 0 || (GetAsyncKeyState('A') && 0x8000) != 0) {
			clearBlock();
			blockX--;
		if (collision()) {
				blockX++;
			}
		drawBlock();
		}
		else if ((GetAsyncKeyState('d') & 0x8000) != 0 || (GetAsyncKeyState('D') && 0x8000) != 0) {
			clearBlock();
			blockX++;
			if (collision()) {
				blockX--;
			}
			drawBlock();
		}
		else if ((GetAsyncKeyState(' ') & 0x8000) != 0 ) {
			rotate();
		}
	}

int main() {
	HWND consoleWnd = GetConsoleWindow();
	ShowWindow(consoleWnd, SW_HIDE);
	srand((unsigned int)time(NULL));
	initgraph(winWidth, winHeight);
	createBlock();
	while (1) {
		drawMap();
		drawBlock();
		move();
		fallBlock();
		Sleep(150);
	}
}