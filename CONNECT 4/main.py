#### IMPORTS ###
import numpy as np
import pygame as pg
import sys
import math
#################

## GLOBAL VARIABLES ###
ROWS = 6
COLUMS = 7

SQUARE_SIZE = 100
RADIUS = int(SQUARE_SIZE/2 - 5)

BLUE = (0,0,255)
BLACK = (0,0,0)
RED = (255,0,0)
YELLOW = (255,255,0)
#########################


### FUNCTIONS ###

# Builds a matrix of 0
def build_board():
    board = np.zeros((ROWS,COLUMS))
    return board

# Flip the board to show it correctly
def show_board(board):
    print(np.flip(board,0))

def draw_board(board):
    for c in range(COLUMS):
        for r in range(ROWS):
            pg.draw.rect(screen, BLUE, (c*SQUARE_SIZE, r*SQUARE_SIZE+SQUARE_SIZE, SQUARE_SIZE, SQUARE_SIZE))
            pg.draw.circle(screen, BLACK, (c*SQUARE_SIZE + SQUARE_SIZE//2, r*SQUARE_SIZE + SQUARE_SIZE//2), RADIUS)
            
            
    for c in range(COLUMS):
        for r in range(ROWS):
            if board[r,c] == 1:
                pg.draw.circle(screen, RED, (c*SQUARE_SIZE+SQUARE_SIZE//2, height-(r*SQUARE_SIZE+SQUARE_SIZE//2)), RADIUS)
            elif board[r,c] == 2: 
                pg.draw.circle(screen, YELLOW, (c*SQUARE_SIZE+SQUARE_SIZE//2, height-(r*SQUARE_SIZE+SQUARE_SIZE//2)), RADIUS)
    
    pg.display.update()

# Draws the circle in the board
def drop_circle(board,row,col,circle):
    board[row,col] = circle

# Checks if the location is valid
def valid_location(board,col):
    return board[ROWS-1,col] == 0

# X
def nxt_open_row(board,col):
    for r in range(ROWS):
        if board[r,col] == 0: # that will mean that it's empty
            return r

# It will tell us who wins
def check_winning(board,piece):

    #NOTE: mejorar para que funcione para cualquier tablero
    # Check horizontals
    for c in range(COLUMS-3):
        for r in range(ROWS):
            if board[r,c] == board[r,c+1] == board[r,c+2] == board[r,c+3] == piece:
                return True
    
    # Check verticals
    for c in range(COLUMS):
        for r in range(ROWS-3):
            if board[r,c] == board[r+1,c] == board[r+2,c] == board[r+3,c] == piece:
                return True
    
    # Check + diagonals
    for c in range(COLUMS-3):
        for r in range(ROWS-3):
            if board[r,c] == board[r+1,c+1] == board[r+2,c+2] == board[r+3,c+3] == piece:
                return True
    
    # Check - diagonals
    for c in range(COLUMS-3):
        for r in range(3,ROWS):
            if board[r,c] == board[r-1,c+1] == board[r-2,c+2] == board[r-3,c+3] == piece:
                return True

#################

### VARIABLES & INITIALIZATION ###
board = build_board()
game_over = False
turn = 0

pg.init() # initialize the screen
width = COLUMS*SQUARE_SIZE
height = (ROWS+1)*SQUARE_SIZE
screen = pg.display.set_mode((width,height))
draw_board(board)
pg.display.update()
myfont = pg.font.SysFont("Arial",75)
###############

### PRINCIPAL LOOP ###
while not game_over:

    for event in pg.event.get():
        if event.type == pg.QUIT:
            sys.exit()

        if event.type == pg.MOUSEMOTION:
            pg.draw.rect(screen,BLACK,(0,0,width,SQUARE_SIZE))
            x_position = event.pos[0]
            if turn == 0:
                pg.draw.circle(screen,RED,(x_position,SQUARE_SIZE//2),RADIUS)
            else:
                pg.draw.circle(screen,YELLOW,(x_position,SQUARE_SIZE//2),RADIUS)
        pg.display.update()

        if event.type == pg.MOUSEBUTTONDOWN:
            pg.draw.rect(screen,BLACK,(0,0,width,SQUARE_SIZE))

            if turn == 0:
                # P1
                x_position = event.pos[0]
                col = int(math.floor(x_position/SQUARE_SIZE))
                #NOTE: añadir try para que se asegure de que es un nº del 0 al 6

                if valid_location(board,col):
                    row = nxt_open_row(board,col)
                    drop_circle(board,row,col,1) # where 1 refers to P1

                    if check_winning(board,1):
                        label = myfont.render("Player 1 wins!",1,RED)
                        screen.blit(label,(40,300))
                        game_over = True

            else:
                # P2
                x_position = event.pos[0]
                col = int(math.floor(x_position/SQUARE_SIZE))
                #NOTE: añadir try para que se asegure de que es un nº del 0 al 6
                
                if valid_location(board,col):
                    row = nxt_open_row(board,col)
                    drop_circle(board,row,col,2) # where 2 refers to P2

                    if check_winning(board,2):
                        label = myfont.render("Player 2 wins!",2,YELLOW)
                        screen.blit(label,(40,300))
                        game_over = True

    print(show_board(board))
    draw_board(board)
    turn +=1
    turn = turn%2 # alternará entre 0 y 1

    if game_over:
        pg.time.delay(3000)
