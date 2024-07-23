#Area of Circle = PI*Radius*Radius
def area(Radius,PI=3.14):
    print("Radius:",Radius)
    print("PI:",PI)
    Result=PI*Radius*Radius
    return Result
def main():
    # output_1=area(10,12)
    # print('Area of circle',output_1)
    # output_1=area(10)
    # print('Area of circle',output_1)
    output_2=area(PI=3,Radius=12)
    print('Area of a circle',output_2)
    #keyword argument and second is default
    output_2=area(Radius=12)
    print('Area of a circle',output_2)
if __name__=="__main__":
    main()