#include<graphics.h>
#include<iostream>
#include<conio.h>
#include<ctime>
#include<cstdlib>
#include<Windows.h>
//------------------------------------------------------------------
#define GRID_SIZE 20//每个格子的大小
const int winWidth = 600;//窗口宽度
const int winHeight = 400;//窗口高度
int snakeX[100], snakeY[100];//最多存100节蛇身
 int snakeLen = 3;
char direction = 'R';
int foodX,foodY;
//--------------------------------------------------------------------
void DrawBorder() {//画出窗口的边界
	setlinecolor(BLACK);//设置线条的颜色
	rectangle(0, 0, winWidth, winHeight);//窗口矩阵的位置，左上X,左上Y,右下X,右下Y
}
//---------------------------------------------------------------------
void InitSnake() {//定义蛇的初始位置
	for (int i = 0; i < snakeLen; i++) {
		snakeX[i] = 300 - i * GRID_SIZE;
		snakeY[i] = 200;
	}
}
//----------------------------------------------------------------------
void DrawSnake() {
	setfillcolor(GREEN);//蛇身填充颜色为绿色
	for (int i = 0; i < snakeLen; i++) {
		fillrectangle(snakeX[i], snakeY[i], snakeX[i] + GRID_SIZE, snakeY[i] + GRID_SIZE);
	}
}
//----------------------------------------------------------------------
void HandleInput() {//防止蛇直接回头
	if (GetAsyncKeyState('W') & 0x8000) {
		if (direction != 'D') direction = 'U';
	}
	else if (GetAsyncKeyState('S') & 0x8000) {
		if (direction != 'U') direction = 'D';
	}
	else if (GetAsyncKeyState('A') & 0x8000) {
		if (direction != 'R') direction = 'L';
	}
	else if (GetAsyncKeyState('D') & 0x8000) {
		if (direction != 'L') direction = 'R';
	}
}
//-------------------------------------------------------------------
void MoveSnake(){
	setfillcolor(BLACK);
	fillrectangle(snakeX[snakeLen - 1], snakeY[snakeLen - 1], snakeX[snakeLen - 1] + GRID_SIZE, snakeY[snakeLen - 1] + GRID_SIZE);
		for (int i = snakeLen-1; i>0; i--) {
			snakeX[i] = snakeX[i - 1];
			snakeY[i] = snakeY[i - 1];
		}
		switch (direction) {
		case 'U':snakeY[0] -= GRID_SIZE; break;
		case 'D':snakeY[0] += GRID_SIZE; break;
		case 'L':snakeX[0] -= GRID_SIZE; break;
		case 'R':snakeX[0] += GRID_SIZE; break;
		}
		
		setfillcolor(GREEN);
		for (int i = 0; i < snakeLen; i++) {
			fillrectangle(snakeX[i], snakeY[i], snakeX[i] + GRID_SIZE, snakeY[i] + GRID_SIZE);
		}
	}
//---------------------------------------------------------------------
void InitFood() {
	srand((unsigned int)time(NULL));
	foodX = (rand() % (winWidth / GRID_SIZE - 2)) * GRID_SIZE + GRID_SIZE;
	foodY = (rand() % (winHeight / GRID_SIZE - 2)) * GRID_SIZE + GRID_SIZE;
	setfillcolor(RED);
	fillrectangle(foodX, foodY, foodX + GRID_SIZE, foodY + GRID_SIZE);
}
//------------------------------------------------------------------------
bool EatFood() {
	if (snakeX[0] == foodX && snakeY[0] == foodY) {
		snakeLen++;
		InitFood();
		return true;
	}
	return false;
}
//------------------------------------------------------------------------
bool GameOver() {
	if (snakeX[0]<0 || snakeX[0] + GRID_SIZE>winWidth||snakeY[0]<0||snakeY[0]+GRID_SIZE>winHeight) {
		return true;
	}
	for (int i = 1; i < snakeLen; i++) {
	if (snakeX[0] == snakeX[i] &&snakeY[0] == snakeY[i]) {
			return true;
		}
	}
	return false;
}
//--------------------------------------------------------------------------
void show() {
	settextcolor(RED);
	settextstyle(24, 0, _T("宋体"));
	outtextxy(winWidth / 2 - 80, winWidth / 20 - 20, _T("GAME OVER!"));
}
//--------------------------------------------------------------------
int main() {
	initgraph(winWidth,winHeight);//初始化图形窗口
	ShowWindow(GetConsoleWindow(), SW_HIDE);
	DrawBorder();
	InitSnake();
	DrawSnake();
	InitFood();
	while (1) {
		HandleInput();
		if (!EatFood()) {
			setfillcolor(BLACK);
			fillrectangle(snakeX[snakeLen - 1], snakeY[snakeLen - 1], snakeX[snakeLen - 1] + GRID_SIZE, snakeY[snakeLen - 1] + GRID_SIZE);
		}
		MoveSnake();
		if (GameOver()) {
			show();
			break;
		}
		Sleep(150);
	}
	Sleep(1000);
	closegraph();//关闭窗口
	return 0;

}