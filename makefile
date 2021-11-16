build:
	mcs *.cs -out:"Tetris.exe"
run:
	mono Tetris.exe
all:
	mcs *.cs -out:"Tetris.exe"
	mono Tetris.exe