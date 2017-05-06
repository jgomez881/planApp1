package co.edu.eafit.dis.analisisnumerico;


import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Button;

public class FixedPointActivity extends AppCompatActivity {

    private EditText expFText,expGText,iterExp,tolText,iniValText,resultText;
    private Button sendBtn;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_fixed_point);

        expFText = (EditText)findViewById(R.id.expFText);
        expGText = (EditText)findViewById(R.id.expGText);
        iterExp = (EditText)findViewById(R.id.iterExp);
        tolText = (EditText)findViewById(R.id.tolText);
        iniValText = (EditText)findViewById(R.id.iniValText);
        resultText = (EditText)findViewById(R.id.resultText);
        sendBtn = (Button)findViewById(R.id.sendBtn);
    }

    public void onSendClick(View view){
        String[] data = new String[5];
        data[0] = expFText.getText().toString();
        data[1] = expGText.getText().toString();
        data[2] = iterExp.getText().toString();
        data[3] = tolText.getText().toString();
        data[4] = iniValText.getText().toString();
        resultText.setText(FixedPointUtil.fixedPoint(data[0], data[1], Integer.parseInt(data[2]),
                Double.parseDouble(data[3]), Double.parseDouble(data[4])));
    }
}
