import math


def volume(s1, s2, x):
    return (s1 * s2 * x) / 2 - (s1 + s2) * (x ** 2) + 2 * (x ** 3)


def maxVertex(s1, s2):
    return ((s1 + s2) / 6) - math.sqrt((s1 + s2) ** 2 / 36 - (s1 * s2 / 12))


s1 = float(input("Längden på papprets ena sidan: "))
s2 = float(input("Längden på papprets andra sidan: "))

x = maxVertex(s1, s2)

print("Maxvolymen med lock är: " + str(volume(s1, s2, x)))
print("Maxvolymen utan lock är: " + str(volume(s1, s2, x) * 2))
print("Höjden på lådan är: " + str(maxVertex(s1, s2)))
