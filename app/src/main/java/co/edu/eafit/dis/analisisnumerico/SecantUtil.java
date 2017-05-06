package co.edu.eafit.dis.analisisnumerico;


public class SecantUtil {

    public static String secant(String f, int iter, double tol, double x1, double x0) {
        double y0 = ExpressionEvalUtil.function(f, x0);
        double y1 = ExpressionEvalUtil.function(f, x1);
        if (y0 != 0) {
            int count = 0;
            double E = tol + 1;
            double div = y1 - y0;
            double y2 = 1;

            while ((y1 != 0) && (y2!=0) && (E > tol) && (count < iter)) {
                double x2 = x1-((y1*(x1-x0))/(div)) ;
                E = Math.abs(x1 - x0);
                x0 = x1;
                x1 = x2;
                y0 = ExpressionEvalUtil.function(f, x0);
                y1 = ExpressionEvalUtil.function(f, x1);
                div = y1-y0;
                y2 = ExpressionEvalUtil.function(f, x2);
                count++;
            }
            if (y1 == 0) {
                return Double.toString(x0)+" is a root";
            } else if (y2 == 0) {
                return Double.toString(x1)+" is a root";
            } else if (E < tol) {
                return Double.toString(x1)+" is an approximate root, error < tolerance";
            } else if (div == 0) {
                return "Division by zero";
            } else {
                return "Failure, has exceeded the maximum number of iterations";
            }
        }else {
            return Double.toString(x0)+" is a root";
        }
    }
}
