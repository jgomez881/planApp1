package co.edu.eafit.dis.analisisnumerico;


public class NewtonUtil {

    public static String newton(String f, String fp, int iter, double tol,double x0){
        double y = ExpressionEvalUtil.function(f,x0);
        double dy = ExpressionEvalUtil.function(fp,x0);
        int count = 0;
        double E = tol + 1;
        while ((y != 0) && dy!=0 && (E > tol) && (count < iter)){
            double x1 = x0 -(y/dy);
            y = ExpressionEvalUtil.function(f,x1);
            dy = ExpressionEvalUtil.function(fp,x1);
            E = Math.abs(x1-x0);
            x0 = x1;
            count ++;
        }
        if (y == 0) {
            return Double.toString(x0)+" is a root";
        }else if (dy == 0){
            return "Division by zero";
        }else if (E < tol){
            return Double.toString(x0)+" is an approximate root, error < tolerance";
        }else{
            return "Failure, has exceeded the maximum number of iterations";
        }
    }

}
