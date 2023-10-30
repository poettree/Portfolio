import cv2
import numpy as np
import Utils as utils

###############################

webcam = False
path = 'OpenCV/Realtime Object Measurement/20231030_235417.jpg'
cap = cv2.VideoCapture(0)
cap.set(10, 160)
cap.set(3, 1920)
cap.set(4, 1080)
scale = 3
wP = 297 * scale
hP = 210 * scale

while True:
    if webcam:success, img = cap.read()
    else: img = cv2.imread(path)
    
    
    img, conts = utils.getContours(img, minArea= 50000, filter=4)
    
    if len(conts) !=0:
        biggest = conts[0][2]
        #print(biggest)
        imgwarp = utils.warpImg(img,biggest,wP,hP)
        cv2.imshow('A4', imgwarp)
    
    img = cv2.resize(img,(0,0),None, 0.2,0.2)
    cv2.imshow('Original', img)
    cv2.waitKey(1)
    