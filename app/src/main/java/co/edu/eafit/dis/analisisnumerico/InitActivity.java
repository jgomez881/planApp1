package co.edu.eafit.dis.analisisnumerico;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.ListView;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.view.View;
import android.widget.Toast;

public class InitActivity extends AppCompatActivity {

    private static ListView list_view;
    private static String[] METHODS = new String[] {
            "Incremental Search", "Bisection", "False Rule",
            "Fixed Point", "Newton", "Secant", "MultipleRoots"
    };


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_init);
        listView();
    }

    public void listView(){
        list_view = (ListView)findViewById(R.id.listView);
        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this,R.layout.method_list,METHODS);
        list_view.setAdapter(adapter);
        list_view.setOnItemClickListener(
                new AdapterView.OnItemClickListener() {
                    @Override
                    public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                        String value = (String)list_view.getItemAtPosition(position);
                        Intent intent;
                        switch(value){
                            case "Incremental Search":
                                intent = new Intent(InitActivity.this,IncrementalSearchActivity.class);
                                startActivity(intent);
                                break;
                            case "Bisection":
                                intent = new Intent(InitActivity.this,BisectionActivity.class);
                                startActivity(intent);
                                break;
                            case "False Rule":
                                intent = new Intent(InitActivity.this,FalseRuleActivity.class);
                                startActivity(intent);
                                break;
                            case "Fixed Point":
                                intent = new Intent(InitActivity.this,FixedPointActivity.class);
                                startActivity(intent);
                                break;
                            case "Newton":
                                intent = new Intent(InitActivity.this,NewtonActivity.class);
                                startActivity(intent);
                                break;
                            case "Secant":
                                intent = new Intent(InitActivity.this,SecantActivity.class);
                                startActivity(intent);
                                break;
                            case "Multiple Roots":
                                intent = new Intent(InitActivity.this,FixedPointActivity.class);
                                startActivity(intent);
                                break;
                        }

                    }
                }
        );
    }
}
