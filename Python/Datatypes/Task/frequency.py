def frequency(name,searchletter):
    count=0
    for i in range(len(name)):
        if(name[i]==searchletter):
            count+=1
    return count


def main():
    maps={}
    name=input("Enter the String:")
    visited=[]
    for i in name:
        searchVaue=i
        result=frequency(name,searchVaue)
        maps[i]=result

    for key,value in maps.items():
        print(f'the letter {key} in {name} repeated {value} times')


if __name__=="__main__":
    main()