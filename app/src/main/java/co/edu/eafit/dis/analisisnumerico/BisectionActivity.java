package co.edu.eafit.dis.analisisnumerico;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

public class BisectionActivity extends AppCompatActivity {

    EditText exprText, iterText, tolText, infText, supText, resultText;
    Button sendBtn;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_bisection);
        exprText = (EditText)findViewById(R.id.exprText);
        iterText = (EditText)findViewById(R.id.iterText);
        tolText = (EditText)findViewById(R.id.tolText);
        infText = (EditText)findViewById(R.id.infText);
        supText = (EditText)findViewById(R.id.supText);
        resultText = (EditText)findViewById(R.id.resultText);

        sendBtn = (Button)findViewById(R.id.sendBtn);
    }

    public void onSendClick(View view) {
        String[] data = new String[5];
        data[0] = exprText.getText().toString();
        data[1] = iterText.getText().toString();
        data[2] = tolText.getText().toString();
        data[3] = infText.getText().toString();
        data[4] = supText.getText().toString();
        resultText.setText(BisectionUtil.bisection(data[0], Integer.parseInt(data[1]),
                Double.parseDouble(data[2]), Double.parseDouble(data[3]),
                Double.parseDouble(data[4])));
    }
}
