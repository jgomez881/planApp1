package co.edu.eafit.dis.analisisnumerico;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class NewtonActivity extends AppCompatActivity {

    private EditText expText, exp2Text, iterText, tolText, iniValText, resultText;
    private Button sendBtn;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_bisection);
        expText = (EditText)findViewById(R.id.expText);
        exp2Text = (EditText)findViewById(R.id.exp2Text);
        iterText = (EditText)findViewById(R.id.iterText);
        tolText = (EditText)findViewById(R.id.tolText);
        iniValText = (EditText)findViewById(R.id.iniValText);
        resultText = (EditText)findViewById(R.id.resultText);

        sendBtn = (Button)findViewById(R.id.sendBtn);
    }

    public void onSearchClick(View view){
        String[] data = new String[5];
        data[0] = expText.getText().toString();
        data[1] = exp2Text.getText().toString();
        data[2] = iterText.getText().toString();
        data[3] = tolText.getText().toString();
        data[4] = iniValText.getText().toString();
        resultText.setText(NewtonUtil.newton(data[0], data[1], Integer.parseInt(data[2]),
                Double.parseDouble(data[3]), Double.parseDouble(data[4])));
    }
}
