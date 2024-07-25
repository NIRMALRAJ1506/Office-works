def calculate_grade(marks,grades):
    for i in marks:
        if marks[i]>=grades["O"]:
            print(f'Subject:{i} Mark:{marks[i]} Grade:O')
        elif marks[i]>=grades["A"]:
            print(f'Subject:{i} Mark:{marks[i]} Grade:A')
        elif marks[i]>=grades["B"]:
            print(f'Subject:{i} Mark:{marks[i]} Grade:B')
        elif marks[i]>=grades["C"]:
            print(f'Subject:{i} Mark:{marks[i]} Grade:C')
        elif marks[i]>=grades["D"]:
            print(f'Subject:{i} Mark:{marks[i]} Grade:D')
        elif marks[i]>=grades["E"]:
            print(f'Subject:{i} Mark:{marks[i]} Grade:E')
        else:
            print(f'Subject:{i} Mark:{marks[i]} Grade:Fail')

def main():
    grades={
        "O":100,
        "A":90,
        "B":80,
        "C":70,
        "D":60,
        "E":50
    }

    marks={}
    for i in range(0,4):
        subject=input("Enter the subject name")
        value=int(input("Enter the marks"))
        marks[subject]=value
    print(marks)
    print('----------GRADES----------')
    calculate_grade(marks,grades)
if __name__=="__main__":
    main()