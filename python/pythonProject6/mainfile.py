# name = input('enter your name: ')
#
# if name.startswith('E') and name.endswith('A'):
#     print(name, ' You entered in programm')
#     print('Welcome', name)
# elif name.endswith('ya'):
#     print(name, ',You do not have pas, you must pay for a subscription')
# else:
#     print('I do not know this user')
#
#     print('end')
#
# HELP = """Доступные команды:
# help - напечатать справку
# add - добавить задачу
# print - распечатать все задачи
# exit - выход из программы
# """
# tasks = ['Уберись в квартире']
# while True:
#     command = input('Введите команду: ')
#     if command == 'help':
#         print(HELP)
#     elif command == 'add':
#         task = input('Введите задачу')
#         tasks.append(task)
#     elif command == 'print':
#         print(tasks)
#     elif command == 'exit':
#         exit('Спасибо за использование! До свидания!')
#     else:
#         print('Введена неверная команда')
# print('end')


# HELP = """Dostupniye komandi:
# help - napecatat spravku
# add - dobavit zadacu
# print - raspecatat vse zadaci
# exit - viyti iz programmi
# delete - udalit zadacu
# """
# print('Zdarova pirajok   XD')
#
#
#
# print(HELP)
# today = ['ubratsa v komnate', 'razrabotat kod', 'plavat']
# other = ['ucitsa', 'spat', 'kuwat']
# tomorrow = ['rabotat', 'otdixat', 'igrat']
#
#
# while True:
#   command = input('Vvedite komandu: ')
#
#   if command == 'help':
#     print(HELP)
#   elif command == 'add':
#     day = input('Kakoy den - segodnya, zavtra ili drugiye dni: ')
#     task = input('Vvedite zadacu: ')
#     if day == 'segodnya' :
#       today.append(task)
#       print(today)
#     elif day == 'zavtra' :
#       tomorrow.append(task)
#       print(tomorrow)
#     else:
#       other.append(task)
#       print(other)
#   elif command == 'print':
#     print('segodnya', today)
#     print('zavtra', tomorrow)
#     print('drugiye', other)
#   elif command == 'delete' :
#     day = input('Kakoy den - segodnya, zavtra ili drugiye dni: ')
#     task = input('Vvedite udalyaemuyu zadacu zadacu: ')
#     if day == 'segodnya' :
#       today.remove(task)
#       print(today)
#     elif day == 'zavtra' :
#       tomorrow.remove(task)
#       print(tomorrow)
#     else:
#       other.remove(task)
#       print(other)
#   elif command == 'exit':
#     print('Dosvidos, drug')
#     break
#   else:
#     break
#
#
# print('End')
import csv

# file =  open('C:/Users/HP/Desktop/loans_full_schema.csv')
# print(file.read())