package co.edu.eafit.dis.analisisnumerico;


public class FixedPointUtil {

    public static String fixedPoint(String f,String g, int iter, double tol, double x0){
        double y = ExpressionEvalUtil.function(f,x0);
        int count = 0;
        double E = tol + 1;
        while ((y != 0) && (E > tol) && (count < iter)){
            double x1 = ExpressionEvalUtil.function(g,x0);
            E = Math.abs(x1-x0);
            x0 = x1;
            y = ExpressionEvalUtil.function(f,x0);
            count ++;
        }
        if (y == 0) {
            return Double.toString(x0)+" is a root";
        }else if (E < tol){
            return Double.toString(x0)+" is an approximate root, error < tolerance";
        }else{
            return "Failure, has exceeded the maximum number of iterations";
        }
    }
}
