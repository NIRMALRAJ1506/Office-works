student_id=[123,124,125,126,127]
try:
    for i in student_id:
        print(i,'-',student_id[i])
except:
    print('Index out of Range')