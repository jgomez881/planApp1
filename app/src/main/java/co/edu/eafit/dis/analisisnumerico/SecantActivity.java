package co.edu.eafit.dis.analisisnumerico;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class SecantActivity extends AppCompatActivity {

    private EditText expText, iterText, tolText, infText, supText, resultText;
    private Button sendBtn;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_secant);
        expText = (EditText)findViewById(R.id.expText);
        iterText = (EditText)findViewById(R.id.iterText);
        tolText = (EditText)findViewById(R.id.tolText);
        infText = (EditText)findViewById(R.id.infText);
        supText = (EditText)findViewById(R.id.supText);
        resultText = (EditText)findViewById(R.id.resultText);

        sendBtn = (Button)findViewById(R.id.sendBtn);
    }

    public void onSearchClick(View view){
        String[] data = new String[5];
        data[0] = expText.getText().toString();
        data[1] = iterText.getText().toString();
        data[2] = tolText.getText().toString();
        data[3] = infText.getText().toString();
        data[4] = supText.getText().toString();
        resultText.setText(SecantUtil.secant(data[0], Integer.parseInt(data[1]),
                Double.parseDouble(data[2]), Double.parseDouble(data[3]),
                Double.parseDouble(data[4])));
    }
}
