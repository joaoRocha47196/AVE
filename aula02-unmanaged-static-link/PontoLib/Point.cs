public class Point{

    public double x;
    public double y;
    
    public Point (double x1, double y1){
        x = x1;
        y = y1;
    }

    public void getModule(){
        return Math.sqrt(x*x + y*y);
    }
}