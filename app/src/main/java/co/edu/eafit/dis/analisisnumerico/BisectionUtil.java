package co.edu.eafit.dis.analisisnumerico;


public class BisectionUtil {


    public static String bisection(String f, int iter, double tol, double xi, double xs){
        double yi = ExpressionEvalUtil.function(f,xi);
        double ys = ExpressionEvalUtil.function(f,xs);

        if(yi == 0){
            return Double.toString(xi);
        }else if(ys == 0){
            return Double.toString(xs);
        }else if ((yi * ys) > 0){
            return "Error, There is no a root in the interval";
        }else{
            double xm = (xi + xs)/2;
            double ym = ExpressionEvalUtil.function(f,xm);
            double E = tol + 1;
            int count = 1;
            while((ym != 0) && (E > tol) && (count < iter)){
                if((ym * yi) < 0){
                    xs = xm;
                    ys = ym;
                }else{
                    xi = xm;
                    yi = ym;
                }
                double xaux = xm;
                xm = (xi + xs)/2;
                ym = ExpressionEvalUtil.function(f,xm);
                E = Math.abs(xm - xaux);
            }
            if(ym == 0){
                return Double.toString(xm);
            }else if(E < tol){
                return Double.toString(xm) + " is an approximate root, E < tolerance";
            }else{
                return "Failure, has exceeded the maximum number of iterations";
            }
        }
    }
}
