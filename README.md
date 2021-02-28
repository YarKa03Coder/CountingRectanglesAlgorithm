# CountingRectanglesAlgorithm
![Codecov](https://img.shields.io/static/v1?label=coverage&message=91.40%&color=green)
## Short description
Solving such task, as finding the number of rectangles(orthogonal), from the incoming coordinates array.
## Algorithm explanation
Let's imagine, that we have next coordinates (x, y) array: ```[3, 4, 3, 10, 3, 8, 3, 6, 8, 10, 8, 6, 8, 4]```  
<i><b>First step</b></i>, is to divide the points into ordered lists of 'y' coordinates, grouped by 'x' coordinate. In our case, we would have four sorted lists as below:
```
3: [4, 6, 8, 10]
8: [4, 6, 10]
```
<i><b>Second step</b></i> is intersecting both lists, we get: ```[4, 6, 10]```  
Any two of them form a rectangle, like it's shown below:
```
[4, 6] => (3, 4), (3, 6), (8, 4), (8, 6)
[4, 10] => (3, 4), (3, 10), (8, 4), (8, 10)
[6, 10] => (3, 6), (3, 10), (8, 6), (8, 10)
```
So, the <i><b>third(final) step</b></i> is to count the number of rectangles.

<b>!!! Note !!!</b>  
This solution only works for orthogonal rectangles, that is, with sides parallel to the x, y axis.
