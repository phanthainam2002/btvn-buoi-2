stock = ['T-Shirt', ' Sweater']
while True:
    hoi = input("welcome to our shop, what do you want (C,R,U,D)")
    if hoi.upper() == "C":
        ask1 = input("Enter the new item")
        stock.append(ask1)
        print("Our item :", stock)
    if hoi.upper() == "R":
        print("Our item :", stock)
    if hoi.upper() == "U":
        ask1 = int(input("Update position :"))
        if ask1 in stock:
            ask2 = input("New item?")
            stock[ask1]= ask2
            print("Our item :", stock)
        else:
            print("cannot find the item !")
    if hoi.upper()== "D":
        ask1 = int(input("Delete position"))
        if ask1 in stock:
            stock.remove(ask1)
            print("Our item :", stock)
        else:
            print("cannot find the item !")

