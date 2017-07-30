from turtle import*
shape("turtle")
colors = ['red', 'blue', 'brown', 'yellow', 'grey']
for cl in colors:
    for time in range(2):
        color(cl)
        begin_fill()
        forward(60)
        left(90)
        forward (100)
        left(90)
        end_fill()
    forward(60)
