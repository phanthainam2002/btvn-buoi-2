from turtle import*
shape('turtle')
colors = ['red','blue','brown','yellow','grey']
a= 0
for i in range(3, 8):
    color(colors[a])
    a = a+1
    for e in range(i):
        print (e)
        forward (100)
        left(360/i)
         
