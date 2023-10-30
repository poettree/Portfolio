import numpy as np
import cv2

img = cv2.imread('OpenCV\lonelygirl_infront_of_window.png', 1)
#배경 필요 없을때
#img = np.zeros([512,512,3], np.uint8)

#img = cv2.line(img, (0,0),(255,255), (255,0,0),3)
#img = cv2.arrowedLine(img, (0,0), (255,255), (147,96,44),10)
#img = cv2.rectangle(img, (350,0), ( 800,300), (0,0,255), -1)
img = cv2.circle(img, (1500,350), 50, (0,255,255), -1)

font = cv2.FONT_HERSHEY_SIMPLEX
img = cv2.putText(img,'Draw Geometry by OpenCV', (20,950), font,2,(255,255,255),5, cv2.LINE_AA)

cv2.imshow('image', img)
cv2.imwrite('OpenCV\lonelygirl_with_moon_infront_of_window.png',img)

cv2.waitKey(0)

cv2.destroyAllWindows()