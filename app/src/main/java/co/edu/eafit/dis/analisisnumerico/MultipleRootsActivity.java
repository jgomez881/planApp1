package co.edu.eafit.dis.analisisnumerico;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class MultipleRootsActivity extends AppCompatActivity {

    private EditText expText, exp2Text, exp3Text, iterText, tolText, iniValText,resultText;
    private Button sendBtn;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_multiple_roots);
        expText = (EditText)findViewById(R.id.expText);
        exp2Text = (EditText)findViewById(R.id.exp2Text);
        exp3Text = (EditText)findViewById(R.id.exp3Text);
        iterText = (EditText)findViewById(R.id.iterText);
        tolText = (EditText)findViewById(R.id.tolText);
        iniValText = (EditText)findViewById(R.id.iniValText);
        resultText = (EditText)findViewById(R.id.resultText);

        sendBtn = (Button)findViewById(R.id.sendBtn);
    }

    public void onSearchClick(View view){
        String[] data = new String[6];
        data[0] = expText.getText().toString();
        data[1] = exp2Text.getText().toString();
        data[2] = exp3Text.getText().toString();
        data[3] = iterText.getText().toString();
        data[4] = tolText.getText().toString();
        data[5] = iniValText.getText().toString();
        MultipleRootsUtil.multipleRoots(data[0], data[1], data[2],Integer.parseInt(data[3]),
                Double.parseDouble(data[4]), Double.parseDouble(data[5]));
    }


}
