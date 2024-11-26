#### IMPORTS ###
import numpy as np
#################

### FUNCTIONS ###

# it builds a 0 matrix
def build_board():
    r,c = 6,7
    board = np.zeros((r,c))
    return board

#################

### GLOBAL VARIABLES ###
board = build_board()
game_over = False
#########################

## PRINCIPAL LOOP
while not game_over:

    # P1
    # P2