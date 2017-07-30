flocklist=[5,7,300,90,24,50,75]
print("Hello, my name is Nam and these are my ship sizes")
print(flocklist)
a = flocklist.index(max(flocklist))
print("Now my biggest sheep has size",max(flocklist),"let's shear it")
flocklist[a] = 8
print("After shearing, here is my flock")
print(flocklist)
for time in range(4):
    for sheep in flocklist:
        b = flocklist.index(sheep)
        flocklist[b] = sheep + 50
    print("MONTH",time+1)
    print("One month has passed, now here is my flock")
    print (flocklist)
    print("Now my biggest sheep has size",max(flocklist),"let's shear it")
    flocklist[a] = 8
    print("After shearing, here is my flock")
    print(flocklist)
totalsize = flocklist[0]+flocklist[1]+flocklist[2]+flocklist[3]+flocklist[4]+flocklist[5]+flocklist[6]
print ("My flock has size in total:", totalsize)
print ("I would get",totalsize,"x 2$ =" ,totalsize*2,"$")
